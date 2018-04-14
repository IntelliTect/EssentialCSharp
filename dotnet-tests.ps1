[CmdletBinding()]
param(
    [string[]]$Chapter='*',
    $BaseIntermediateOutputPath="obj$([System.IO.Path]::DirectorySeparatorChar)"
)


#[string]$testResultName = 'VisualStudio.TestTools.UnitTesting.TestResult'
#Update-TypeData -TypeName $testResultName  -DefaultDisplayProperty Key -DefaultDisplayPropertySet Project,Total,Passed,Failed,Skipped -Force
[string]$dotnetCliResultName = 'DotNet.Cli.Result'
Update-TypeData -TypeName $dotnetCliResultName  -DefaultDisplayProperty ProjectName -DefaultDisplayPropertySet ProjectName,WarningCount,ErrorCount,TestErrorCount,TotalTests,Passed,Failed,Skipped -Force

Function Invoke-ChapterFullBuild {
    [CmdletBinding()]
    param( 
        [ValidateScript({($_ -like '*Chapter??.Tests.csproj')})]
        [Parameter(ValueFromPipeline,ValueFromPipelineByPropertyName)]
            [Alias('Path','FullName')][string[]]$testProject = 'Chapter??.Tests.csproj'
    )
    BEGIN {
        $warningsGroupedByChapter = @{}
        $errorsGroupbedByChapter = @{}
    }
    PROCESS {
        $testProject | Get-ChildItem -Recurse | ForEach-Object{
            
            $eachTestProjectFile = $_.FullName
            $eachTargetProjectFile = ($eachTestProjectFile -replace '\.Tests','' | Get-Item).FullName

            # Implied when building the test project due to dependency.
            # Invoke-DotNetBuild $eachTargetProjectFile | ForEach-Object{ Add-Member -InputObject $_ NoteProperty 'PSTypeName' $dotnetCliResultName  }
            $errors = $null
            Invoke-DotNetBuild $eachTestProjectFile -ErrorAction SilentlyContinue -ErrorVariable +errors -WarningAction SilentlyContinue -WarningVariable +errors | ForEach-Object{ 
                $buildResult = $_
                Add-Member -InputObject $buildResult NoteProperty 'PSTypeName'  $dotnetCliResultName 
                if($buildResult.ErrorCount -gt 0) {
                    Write-Output $buildResult | Format-ColorizeOutput -severity 'Error'
                }
                else {
                    $testResult = Invoke-DotNetTest $eachTestProjectFile -ErrorAction SilentlyContinue -ErrorVariable +errors -WarningAction SilentlyContinue -WarningVariable +errors
                    Add-Member -InputObject $buildResult NoteProperty 'TestErrorCount'  $testResult.TestErrorCount 
                    Add-Member -InputObject $buildResult NoteProperty 'TotalTests'  $testResult.TotalTests 
                    Add-Member -InputObject $buildResult NoteProperty 'Passed'  $testResult.Passed 
                    Add-Member -InputObject $buildResult NoteProperty 'Failed' $testResult.Failed 
                    Add-Member -InputObject $buildResult NoteProperty 'Skipped'  $testResult.Skipped 
                    if($testResult.TestErrorCount+$testResult.Failed -gt 0) {
                        Write-Output $buildResult | Format-ColorizeOutput -severity 'Error'
                    }
                    elseif($buildResult.warningCount+$buildResult.Skipped -gt 0) {
                        Write-Output $buildResult | Format-ColorizeOutput -severity 'Warning'
                    }                        
                    else{
                        Write-Output | Format-ColorizeOutput
                    }
                }
            }
            #$warningsGroupedByChapter.Add( $eachTargetProjectFile, $warnings )
            $errorsGroupbedByChapter.Add( $eachTargetProjectFile, $errors)
        } 
        
    }
    END {
        @($errorsGroupbedByChapter.GetEnumerator()) | ForEach-Object{ 
            Write-Host $_.Key -ForegroundColor Magenta
            $_.Value | ForEach-Object{
                $output = $null
                $severity = $null;
                if($_ -match ': warning \w\w\d+:') { 
                    $severity = 'Warning'
                    $output = $_.Message
                }
                elseif($_ -match ': error \w\w\d+:') {
                    $severity = 'Error'
                    $output = $_.Exception
                }
                $output | Format-ColorizeOutput $severity
            }
        }
    }
} 

Function Test-IsOsPlatformWindows {
    [CmdletBinding()]
    param(
        #[ValiateSet('Windows','Linux','Mac')][string]$OsPlatform
    )
    return ( ('System.Runtime.InteropServices.RuntimeInformation' -as [Type]) -and
        [System.Runtime.InteropServices.RuntimeInformation]::IsOSPlatform(
            [System.Runtime.InteropServices.OSPlatform]::Windows) )
} 

Function Script:Write-Status {
    [CmdletBinding()]
    param(
        [Parameter(Mandatory)][string]$Message,
        [Parameter(Mandatory)][string]$Activity
    )
    if(Test-IsOsPlatformWindows) { 
        Write-Progress -Activity $Activity -Status $Message
    }
    else {
        Write-Information -Tags $Activity -MessageData $message
    }
}


Function Invoke-DotNetBuild {
    [CmdletBinding()]
    param(
        [ValidateScript({ Test-Path $_})][parameter(Mandatory=$true, ValueFromPipelineByPropertyName=$true)]
            [alias("Path","FullName")][string]$projectPath,
        [string[]]$args
    )
    Write-Verbose "dotnet build $projectPath $args | Read-DotNetBuildOutput"
    dotnet build $projectPath $args | 
        Read-DotNetBuildOutput -ErrorAction SilentlyContinue -ErrorVariable +errors -WarningAction SilentlyContinue -WarningVariable +errors
    $warnings | Write-Warning 
    $errors | Write-Error
}



Function Read-DotNetBuildOutput {
    [CmdletBinding()]
    param(
        [parameter(Mandatory, ValueFromPipeline)][AllowEmptyString()]
            [string[]]$buildOutputLine        
    )
    BEGIN {
        class BuildResult {
            [string]$ProjectName
            [string]$AssemblyPath
            [int]$WarningCount
            [int]$ErrorCount
            [System.Collections.Generic.List`1[BuildOutputResultLine]]$BuildOutputResultLines
            BuildResult() {
                $this.BuildOutputResultLines=New-Object 'System.Collections.Generic.List[BuildOutputResultLine]'
            }
        }
        class BuildOutputResultLine {
            [string]$FileName
            [int]$LineNumber
            [int]$ColumnNumber
            [string]$Severity
            [string]$Message
            [string]$FullMessage
            [string]$ProjectPath
            static [BuildOutputResultLine] Create([string]$resultLine) {
                if( $resultLine -match [BuildOutputResultLine]::RegEx) {
                    #Write-Host $Matches
                    return (New-Object BuildOutputResultLine $matches)
    
                }
                else { throw "Unable to parse $resultLine with $([BuildOutputResultLine]::Regex)" }
            }
            static [string]$RegEx='(?<Error>(?<FileName>.*)\((?<LineNumber>\d+),(?<ColumnNumber>\d+)\):\s(?<Severity>error|warning)\sCS\d\d\d\d:\s(?<Message>.*)(?:\[(?<ProjectPath>.*\.csproj)\]))'
            BuildOutputResultLine([Hashtable]$regexMatch) {
                $this.FileName = $regexMatch.FileName
                $this.LineNumber = $regexMatch.LineNumber
                $this.ColumnNumber = $regexMatch.ColumnNumber
                $this.Severity = $regexMatch.Severity
                $this.Message = $regexMatch.Message
                $this.ProjectPath = $regexMatch.ProjectPath
                $this.FullMessage = $regexMatch.0
            }
            [string] ToString() {
                return $this.FullMessage
            }
        }
        [System.Collections.Generic.List`1[string]]$output=
            new-object 'System.Collections.Generic.List`1[string]'
        [BuildResult]$currentBuildResult=$null
        [bool]$completed = $false
        $activity = "Building..."
    }
    PROCESS{
        Write-Status -Activity $activity -Message " $_"
        if($_ -match '\s(?<ProjectName>.*)\s->\s(?<OutputPath>.*)') {
            $currentBuildResult = New-Object BuildResult
            $currentBuildResult.projectName = $Matches.ProjectName.Trim()
            $currentBuildResult.AssemblyPath = $Matches.OutputPath
            $activity = "Bulding $($currentBuildResult.projectName)"
        }
        elseif($_ -match 'Build (Succeeded|FAILED)\.') {
            if($currentBuildResult -eq $null) {
                $currentBuildResult = New-Object BuildResult
            }
            $activity = "Bulding $($currentBuildResult.projectName)"
            $completed = $true
        }
        elseif($completed) {
            $warningErrorCountRegEx = '\s(?<Count>\d+)\s{0}\(s\)'
            if($_ -match $warningErrorCountRegEx -f 'Error' ) { 
                # Parse error total
                $currentBuildResult.ErrorCount = $Matches.Count 
            }
            elseif($_ -match $warningErrorCountRegEx -f 'Warning') { 
                # Parse warning total
                $currentBuildResult.WarningCount = $Matches.Count 
            }
            elseif($_ -match 'Time Elapsed.*') {
                Write-Output $currentBuildResult
                $activity = "Completed building $($currentBuildResult.ProjectName)"
                # if($currentBuildResult.ErrorCount -gt 0) {
                #     Write-Warning "$($currentBuildResult.ProjectName) failed with $($currentBuildResult.ErrorCount) errors and $($currentBuildResult.WarningCount) warnings."
                # }
                $currentBuildResult = $null
                $completed = $false
                
            }     
            elseif($_.Trim() -eq '') {}       
            else {
                # Parse Error/Warning messages
                if($_ -match [BuildOutputResultLine]::RegEx) {
                    [BuildOutputResultLine]$buildOutputResultLine = New-Object BuildOutputResultLine $matches
                    $currentBuildResult.BuildOutputResultLines.Add( $buildOutputResultLine )
                    if($buildOutputResultLine.Severity -eq 'error') { Write-Error $_ }
                    if($buildOutputResultLine.Severity -eq 'warning') { Write-Warning $_ }
                    if($buildOutputResultLine.ProjectPath -and [string]::IsNullOrWhiteSpace($currentBuildResult.ProjectName)) {
                        # It doesn't seem possible to retrieve the currently compling project from the 
                        # command line when there is an error.  Therefore, we retrieve it from
                        # the end of the error line where the project is shown.
                        $currentBuildResult.ProjectName = [IO.Path]::GetFileNameWithoutExtension($buildOutputResultLine.ProjectPath)
                    }
                }
                else { Write-Error "Unable to parse: $_" -ErrorAction Stop }
            }
        }
    }
    END {
    
    # TODO: Move this into a DotNet class that runs tests, provides parsed output, executes test, etc.
    #       Of course, first check what the dotnetCLI classes provide because resumably they have it all.
    #       See C:\Program Files\dotnet\sdk\...

        
    }
}


Function Invoke-DotNetTest {
    [CmdletBinding()]
    param(
        [ValidateScript({ Test-Path $_})][parameter(Mandatory=$true, ValueFromPipelineByPropertyName=$true)]
            [alias("Path","FullName")][string]$projectPath,
        [string[]]$args = '--no-build',
        [string]$testOutputFilePath = 'Test.Results.txt'
        #, [string]$BaseIntermediateOutputPath = "obj$([System.IO.Path]::DirectorySeparatorChar)"
    )

    dotnet test $projectPath $args | 
        Read-DotNetTestOutput -ErrorAction SilentlyContinue -ErrorVariable +errors -WarningAction SilentlyContinue -WarningVariable +errors
    $warnings | Write-Warning
    $errors | Write-Error

}


Function Read-DotNetTestOutput {
    [CmdletBinding()]
    param(
        [parameter(Mandatory, ValueFromPipeline)][AllowEmptyString()]
            [string[]]$buildOutputLine        
    )
    BEGIN {
        class TestResult {
            # hidden $_ProjectName = $($this | Add-Member ScriptProperty 'ProjectName' `
            #     { "getter $($this._ProjectName)" }`
            #     { <# set #> param ( $arg ) $this._ProjectName = "setter $arg" }
            # )            
            static [string]$TestRegex
            [string]$AssemblyPath
            [int]$TestErrorCount
            [int]$TotalTests
            [int]$Passed
            [int]$Failed
            [int]$Skipped

            static TestResult() {
                [TestResult]::TestRegex = (-join ('Total tests','Passed','Failed','Skipped' | 
                    ForEach-Object{ "\s?$($_):\s?(?<$($_ -replace 'Total tests','TotalTests')>[0-9]+)\.\s?,?"} ))
            }
            TestResult() {
                # Add Project Name property
                $this | Add-Member ScriptProperty 'ProjectName' `
                    { "$([IO.Path]::GetFileNameWithoutExtension($this.AssemblyPath) )" }
            }
        }

        [System.Collections.Generic.List`1[string]]$output=
            new-object 'System.Collections.Generic.List`1[string]'
        [TestResult]$currentTestResult=$null
        [bool]$completed = $false
        $activity = "Begin testing..."
    }
    PROCESS {  

        Script:Write-Status -Activity $activity -Message " $_"
        
        if([string]::IsNullOrWhiteSpace($_)){}
        elseif( $_ -match 'Test run for (?<AssemblyPath>.*)\((?<Platform>.*)\)') {
            $currentTestResult = New-Object TestResult
            $currentTestResult.AssemblyPath = $matches.AssemblyPath
            $activity = "Testing $($currentTestResult.ProjectName)..."
        }
        elseif($_  -match [TestResult]::TestRegEx) {  
            $currentTestResult.TotalTests =  $matches.TotalTests
            $currentTestResult.Passed =  $matches.Passed
            $currentTestResult.Failed =  $matches.Failed
            $currentTestResult.Skipped =  $matches.Skipped
        }
        elseif($_ -match 'The test source file .* provided was not found\.') {
            Write-Error "'$($currentTestResult.ProjectName)' was not found.  This is likely due to an unsuccessful complie."
            $currentTestResult.TestErrorCount++
        }
        elseif($_ -match 'No test is available in .*\. Make sure that test discoverer & executors are registered and platform & framework version settings are appropriate and try again\.') {
            Write-Warning "'$($currentTestResult.ProjectName)' has not tests available: $_"
            $currentTestResult.TestErrorCount++;
        }
        elseif($_ -match 'Test Run .*') {
            # Indicates all is well.
        }
        else {
            Write-Verbose "Ignored output: $_"
        }
    }
    END {
        Write-Output $currentTestResult
    }
}

Function Format-ColorizeOutput {
    [CmdletBinding()]
    param(
        [ValidateSet('Warning','Error')]$severity,
        [Parameter(ValueFromPipeline)]$output
    )
    try{
        [ConsoleColor]$consoleForegroundColor = [Console]::ForegroundColor
        [ConsoleColor]$consoleBackgroundColor = [Console]::BackgroundColor
        switch ($severity) {
            'Warning' { 
                [Console]::ForegroundColor = $host.PrivateData.WarningForegroundColor
                [Console]::BackgroundColor = $host.PrivateData.WarningBackgroundColor
            }
            'Error' {
                [Console]::ForegroundColor = $host.PrivateData.ErrorForegroundColor
                [Console]::BackgroundColor = $host.PrivateData.ErrorBackgroundColor
            }
        }
        Write-Output $output
    }
    finally {
        [Console]::ForegroundColor = $consoleForegroundColor
        [Console]::BackgroundColor = $consoleBackgroundColor 
    }
}







return


Remove-Item -Path 'Test.Results.txt' -ErrorAction ignore
[string[]]$chapters=$null
if($Chapter -ne '*' ) {
    $chapters = ($Chapter | ForEach-Object{ "$_".PadLeft(2, '0')} | ForEach-Object{ "*$_.Tests.csproj" })
}
else {
    $chapters = '*.Tests.csproj'
}


$testResults = $()
$chapterProjects = @(Get-ChildItem -recurse -include $chapters -exclude IntelliTect.TestTools.Console.Tests.csproj | Sort-Object)
if($chapterProjects.Count -gt 0) {
    $format = "{0,-20}{1,10}{2,10}{3,10}{4,10}"
    Write-Host ($format -f 'Errors','Warnings','Project','Total','Passed','Failed','Skipped')
    Write-Host ($format -f '------','--------','-------','-----','------','------','-------')

    $chapterProjects | Invoke-DotNetTest <#-BaseIntermediateOutputPath $BaseIntermediateOutputPath#> | ForEach-Object {
        if($_.Failed -gt 0) { 
            $foregroundColor = [System.ConsoleColor]::Red
        } 
        else {
            if($_.Skipped -gt 0) {
                $foregroundColor = [System.ConsoleColor]::Yellow
            }
            else {
                $foregroundColor = [System.ConsoleColor]::Green
            }
        }
        Write-Host ($format -f $_.Project,$_.Total,$_.Passed,$_.Failed,$_.Skipped) -ForegroundColor $foregroundColor
        $_.TestResultDetail | ForEach-Object{ $testResults += $_ }
    }
}

if(!(Test-Path .\Test.Results.txt)) {
    Write-Warning "No files found for `$Chapter = $Chapter"
}
else {
    $text = (get-content .\Test.Results.txt -raw )

    $matches = @(([regex]'(?smi)^Starting test execution, please wait\.\.\.\w(.*?)\wTotal tests.*?$').Matches($text))

    if($matches.Count -gt 0) {
        Write-Host 
        Write-Host 
        Write-Host "Details"
        Write-Host "----------------------"
        
        $matches | Select-Object -ExpandProperty Groups | 
        Select-Object -skip 1 | 
        Select-Object -ExpandProperty Value | ForEach-Object{ $_ -split [Environment]::NewLine } |
        ForEach-Object {
            try{$foregroundColor = ((Get-Host).UI.RawUI.ForegroundColor)} catch{ <# Igore #>} 
            if(!$foregroundColor -OR ($foregroundColor -lt 0)) {
                $foregroundColor =  [System.ConsoleColor]:: White
            }
            if($_ -like "Skipped *") { $foregroundColor = [System.ConsoleColor]::Yellow }
            if($_ -like "Failed *") { $foregroundColor = [System.ConsoleColor]::Red }

            Write-Host $_ -ForegroundColor $foregroundColor
        }
    }
}

Write-Host ""


$SampleBuildOutput = @"
Sample Build Output:
Build FAILED.

Listing04.16.CountingLinesGivenADirectory.Tests.cs(1,10): warning CS1030: #warning: 'TODO: 4.15 tests' [C:\Dropbox\EssentialCSharp\SCC\src\Chapter04.Tests\Chapter04.Tests.csproj]
Listing04.17.CountingLinesUsingOverloading.Tests.cs(1,10): warning CS1030: #warning: 'TODO: 4.16 tests' [C:\Dropbox\EssentialCSharp\SCC\src\Chapter04.Tests\Chapter04.Tests.csproj]
Listing04.18.MethodsWithOptionalParameters.Tests.cs(1,10): warning CS1030: #warning: 'TODO: 4.17 tests' [C:\Dropbox\EssentialCSharp\SCC\src\Chapter04.Tests\Chapter04.Tests.csproj]
Listing04.15.PassingAVariableParameterList.Tests.cs(30,17): error CS0103: The name 'Program' does not exist in the current context [C:\Dropbox\EssentialCSharp\SCC\src\Chapter04.Tests\Chapter04.Tests.csproj]
Listing04.14A.Tests.cs(16,17): error CS0103: The name 'Program' does not exist in the current context [C:\Dropbox\EssentialCSharp\SCC\src\Chapter04.Tests\Chapter04.Tests.csproj]
Listing04.14.PassingVariablesOutOnly.Tests.cs(19,17): error CS0103: The name 'ConvertToPhoneNumber' does not exist in the current context [C:\Dropbox\EssentialCSharp\SCC\src\Chapter04.Tests\Chapter04.Tests.csproj]
Listing04.14.PassingVariablesOutOnly.Tests.cs(32,17): error CS0234: The type or namespace name 'ConvertToPhoneNumber' does not exist in the namespace 'AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_13' (are you missing an assembly reference?) [C:\Dropbox\EssentialCSharp\SCC\src\Chapter04.Tests\Chapter04.Tests.csproj]
Listing04.14.PassingVariablesOutOnly.Tests.cs(45,17): error CS0234: The type or namespace name 'ConvertToPhoneNumber' does not exist in the namespace 'AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_13' (are you missing an assembly reference?) [C:\Dropbox\EssentialCSharp\SCC\src\Chapter04.Tests\Chapter04.Tests.csproj]
Listing04.13.PassingVariablesByReference.Tests.cs(16,17): error CS0103: The name 'Program' does not exist in the current context [C:\Dropbox\EssentialCSharp\SCC\src\Chapter04.Tests\Chapter04.Tests.csproj]
Listing04.05A.Tests.cs(19,17): error CS0103: The name 'Program' does not exist in the current context [C:\Dropbox\EssentialCSharp\SCC\src\Chapter04.Tests\Chapter04.Tests.csproj]
Listing04.12.PassingVariablesByValue.Tests.cs(17,17): error CS0103: The name 'Program' does not exist in the current context [C:\Dropbox\EssentialCSharp\SCC\src\Chapter04.Tests\Chapter04.Tests.csproj]
Listing04.11.PassingCommandLineArgumentsToMain.Tests.cs(21,17): error CS0103: The name 'Program' does not exist in the current context [C:\Dropbox\EssentialCSharp\SCC\src\Chapter04.Tests\Chapter04.Tests.csproj]
Listing04.11.PassingCommandLineArgumentsToMain.Tests.cs(32,36): error CS0103: The name 'Program' does not exist in the current context [C:\Dropbox\EssentialCSharp\SCC\src\Chapter04.Tests\Chapter04.Tests.csproj]
    3 Warning(s)
    10 Error(s)

Time Elapsed 00:00:09.78
"@