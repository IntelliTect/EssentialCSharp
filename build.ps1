[CmdletBinding()]
param(
    [ValidateScript({$regex = '(.*Chapter)?(\d?\d|\??\?|\*)(\.Tests\.csproj)?';$_ -match $regex })]
    [Parameter(Position=0,ParameterSetName='ChapterNumber',ValueFromPipeline,ValueFromPipelineByPropertyName,
        HelpMessage="Provide the chapter number.  * or ? wildcards are also supported")]
        [string[]]$chapterFilter= @('*')
)

$script:Invoke_ChapterFullBuild_Regex = '(.*Chapter)?(\d?\d|\??\?|\*)(\.Tests\.csproj)?'

Function Invoke-ChapterFullBuild {
    [CmdletBinding(DefaultParameterSetName='ChapterNumber')]
    param(
        [ValidateScript({@($_) | %{$regex = $Invoke_ChapterFullBuild_Regex; $_ -match $regex} })]
        [Parameter(Position=0,ParameterSetName='ChapterNumber',ValueFromPipeline,ValueFromPipelineByPropertyName,Mandatory,
            HelpMessage="Provide the chapter number.  * or ? wildcards are also supported")]
            [string[]]$chapterFilter = @('*')
    )
    BEGIN {
        $errorsGroupbedByChapter = @{}
    }
    PROCESS {
        if($chapterFilter -match '\d') { $chapterFilter = $chapterFilter.PadLeft(2,'0') }
        if($chapterFilter.Length -le 2) { $testProject = "Chapter$chapterFilter.Tests.csproj" }
        $testProject | Get-ChildItem -Recurse | ForEach-Object{

            $eachTestProjectFile = $_.FullName
            $eachTargetProjectFile = ($eachTestProjectFile -replace '\.Tests','' | Get-Item).FullName

            # Implied when building the test project due to dependency.
            # Invoke-DotNetBuild $eachTargetProjectFile | ForEach-Object{ Add-Member -InputObject $_ NoteProperty 'PSTypeName' $dotnetCliResultName  }
            $errors = $null
            Invoke-DotNetBuild $eachTestProjectFile -ErrorAction SilentlyContinue -ErrorVariable +errors -WarningAction SilentlyContinue -WarningVariable +errors | ForEach-Object{
                $buildResult = $_
                $buildResult.ProjectName = "$($buildResult.ProjectName)  " -replace '\.Tests',''
                if($buildResult.ErrorCount -gt 0) {
                    Add-Member -InputObject $buildResult NoteProperty 'TestErrorCount'  'N/A'
                    Add-Member -InputObject $buildResult NoteProperty 'TotalTests'  'N/A'
                    Add-Member -InputObject $buildResult NoteProperty 'Passed'  'N/A'
                    Add-Member -InputObject $buildResult NoteProperty 'Failed' 'N/A'
                    Add-Member -InputObject $buildResult NoteProperty 'Skipped'  'N/A'
                    Write-Output $buildResult
                }
                else {
                    $testResult = Invoke-DotNetTest $eachTestProjectFile -ErrorAction SilentlyContinue -ErrorVariable +errors -WarningAction SilentlyContinue -WarningVariable +errors
                    Add-Member -InputObject $buildResult NoteProperty 'TestErrorCount'  "$($testResult.TestErrorCount)"
                    Add-Member -InputObject $buildResult NoteProperty 'TotalTests'  "$($testResult.TotalTests)"
                    Add-Member -InputObject $buildResult NoteProperty 'Passed'  "$($testResult.Passed)"
                    Add-Member -InputObject $buildResult NoteProperty 'Failed' "$($testResult.Failed)"
                    Add-Member -InputObject $buildResult NoteProperty 'Skipped'  "$($testResult.Skipped)"
                    if($testResult.TestErrorCount+$testResult.Failed -gt 0) {
                        Write-Output $buildResult
                    }
                    elseif($buildResult.warningCount+$buildResult.Skipped -gt 0) {
                        Write-Output $buildResult
                    }
                    else{
                        Write-Output $buildResult
                    }
                }
            }
            $errorsGroupbedByChapter.Add( $eachTargetProjectFile, $errors)
        }
    }
    END {
        <#
        @($errorsGroupbedByChapter.GetEnumerator()) | ForEach-Object{
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
                #$output # | Format-ColorizeOutput $severity
            }
        }
        #>
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

[string]$script:WriteStatus_Message=''
Function Script:Write-Status {
    [CmdletBinding()]
    param(
        [Parameter(Mandatory)][string]$Message,
        [Parameter(Mandatory)][string]$Activity,
        [switch]$append
    )
    if(Test-IsOsPlatformWindows) {
        if(!$append.IsPresent) {
            [string]$script:WriteStatus_Message = ''
        }

        $padding = $host.UI.RawUi.BufferSize.Width - ($_.Length % $host.UI.RawUi.BufferSize.Width)
        $script:WriteStatus_Message += "$($_.PadRight($_.Length + $padding))"
        Write-Progress -Activity $Activity -Status $script:WriteStatus_Message
    }
    else {
        Write-Information -Tags $Activity -MessageData $script:WriteStatus_Message
    }
}

Function script:Split {
    [string]$targetGroup = "Line";
    $maxCharacters = 100
    [string]$pattern = [string]::Format( '(?<{0}>.{{1,{1}}})(?:\W|$)', $targetGroup, $MaxCharacters )
    $matches = [Regex]::Matches(
        $sample, $pattern,
        [System.Text.RegularExpressions.RegexOptions]::Multiline -bor [ System.Text.RegularExpressions.RegexOptions]::CultureInvariant )
    $lines =  $matches | Where-Object{ $_.GetType().Name -eq 'Match' } | Select-Object -ExpandProperty Value
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
        Read-DotNetBuildOutput
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
        Update-TypeData -TypeName 'BuildResult'  -DefaultDisplayProperty ProjectName -DefaultDisplayPropertySet ProjectName,ErrorCount,WarningCount,TestErrorCount,TotalTests,Passed,Failed,Skipped,BuildOutputResultLines -Force
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
        $message = ''
    }
    PROCESS{
        if($_ -match '\s(?<ProjectName>.*)\s->\s(?<OutputPath>.*)') {
            # e.g. Chapter16 -> C:\Dropbox\EssentialCSharp\SCC\src\Chapter16\bin\Debug\netcoreapp2.0\Chapter16.dll
            $currentBuildResult = New-Object BuildResult
            $currentBuildResult.projectName = $Matches.ProjectName.Trim()
            $currentBuildResult.AssemblyPath = $Matches.OutputPath
            $activity = "Bulding $($currentBuildResult.projectName)"
            $message = $_
            Write-Status -Activity $activity -Message 'Building...'
            }
        elseif($_ -match 'Build (Succeeded|FAILED)\.') {
            if($currentBuildResult -eq $null) {
                $currentBuildResult = New-Object BuildResult
            }
            $activity = "Bulding $($currentBuildResult.projectName)"
            $completed = $true
            $message = $_
        }
        elseif(!$completed) {
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
            Write-Status -Activity $activity -Message $message -append
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
    )

    dotnet test $projectPath $args |
        Read-DotNetTestOutput
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
                $this | Add-Member ScriptProperty 'TestProjectName' `
                    { "$([IO.Path]::GetFileNameWithoutExtension($this.AssemblyPath) )" }
                $this | Add-Member ScriptProperty 'TargetProjectName' `
                    { "$([IO.Path]::GetFileNameWithoutExtension($this.AssemblyPath).Repace('.Tests','') )" }

            }
        }
        Update-TypeData -TypeName 'TestResult'  -DefaultDisplayProperty TargetProjectName -DefaultDisplayPropertySet ProjectName,ErrorCount,WarningCount,TestErrorCount,TotalTests,Passed,Failed,Skipped -Force

        [System.Collections.Generic.List`1[string]]$output=
            new-object 'System.Collections.Generic.List`1[string]'
        [TestResult]$currentTestResult=$null
        [bool]$completed = $false
        $activity = "Begin testing..."
        $message = ''
    }
    PROCESS {
        Script:Write-Status -Activity $activity -Message $message -append

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

Function Format-ColorizeBuildResult {
    [CmdletBinding()]
    param(
        [Parameter(ValueFromPipeline)]$output
    )
    $output | Write-PSObject -MatchMethod Match,Match,Match,Match `
         -Value '[1-9][0-9]*','[1-9][0-9]*','[1-9][0-9]*','[1-9][0-9]*' `
         -Column 'ErrorCount','WarningCount','Failed','Skipped' `
         -ValueBackColor Red,Yellow,Red,Yellow `
         -ValueForeColor ([Console]::ForegroundColor),Black,([Console]::ForegroundColor),Black
}

Function Format-ColorizeOutput {
    [CmdletBinding()]
    param(
        [ValidateSet('Warning','Error',$null)][AllowNull()][string]$severity,
        [Parameter(ValueFromPipeline)]$output
    )
    PROCESS {
        try{
            [ConsoleColor]$consoleForegroundColor = [Console]::ForegroundColor
            [ConsoleColor]$consoleBackgroundColor = [Console]::BackgroundColor
            [ConsoleColor]$defaultWarningColor = 'Yellow'
            [ConsoleColor]$defaultErrorColor = 'Red'
            try {
                # On ISE $host.PrivateData colors are of type System.Media.Color rather than
                # ConsoleColor so conversion is unsuccessful and we fall back to the defaults.
                switch ($severity) {
                    'Warning' {
                        [Console]::ForegroundColor = $defaultWarningColor
                        [Console]::ForegroundColor = $host.PrivateData.WarningForegroundColor # Might throw exception
                        [Console]::BackgroundColor = $host.PrivateData.WarningBackgroundColor # Might throw exception
                    }
                    'Error' {
                        [Console]::ForegroundColor = $defaultErrorColor
                        [Console]::ForegroundColor = $host.PrivateData.ErrorForegroundColor # Might throw exception
                        [Console]::BackgroundColor = $host.PrivateData.ErrorBackgroundColor # Might throw exception
                    }
                }
            }
            catch { <# Ignore conversion errors and just go with default colors. #> }
            Write-Output $output
        }
        finally {
            [Console]::ForegroundColor = $consoleForegroundColor
            [Console]::BackgroundColor = $consoleBackgroundColor
        }
    }
}



Function Write-ErrorMessage {
    [CmdletBinding(DefaultParameterSetName='ErrorMessage')]
    param(
         [Parameter(Position=0,ParameterSetName='ErrorMessage',Mandatory)][string]$errorMessage
         ,[Parameter(ParameterSetName='ErrorRecord')][System.Management.Automation.ErrorRecord]$errorRecord
         ,[Parameter(ParameterSetName='Exception')][Exception]$exception
    )

    switch($PsCmdlet.ParameterSetName) {
        'ErrorMessage' {
            $err = $errorMessage
        }
        'ErrorRecord' {
            $errorMessage = @($error)[0]
            $err = $errorRecord
        }
        'Exception'   {
            $errorMessage = $exception.Message
            $err = $exception
        }
    }

    Write-Error -Message $err -ErrorAction SilentlyContinue
    $Host.UI.WriteErrorLine($errorMessage)
};

<#
Write-ErrorMessage  "Error message"
Write-Host "Next" -ForegroundColor Cyan
Write-Error "This is a sample error"  -ErrorAction SilentlyContinue
Write-Host "Last" -ForegroundColor Cyan
Write-ErrorMessage $error[0]
Write-ErrorMessage (New-Object Exception  "Exception message")
#>

$help = @"
Added functions:
    $((Get-Command Invoke-ChapterFullBuild -Syntax).Trim())
    $((Get-Command Invoke-DotNetBuild -Syntax).Trim())
    $((Get-Command Invoke-DotNetTest -Syntax).Trim())
    $((Get-Command Read-DotNetTestOutput -Syntax).Trim())
    $((Get-Command Read-DotNetBuildOutput -Syntax).Trim())
    $((Get-Command Format-ColorizeBuildResult -Syntax).Trim())

"@

Write-Host $help

. ./Utilities/Write-PSObject.ps1

$chapterFilter | Invoke-ChapterFullBuild | Write-PSObject -MatchMethod Match,Match,Match,Match `
    -Value '[1-9][0-9]*','[1-9][0-9]*','[1-9][0-9]*','[1-9][0-9]*' `
    -Column 'ErrorCount','WarningCount','Failed','Skipped' `
    -ValueBackColor Red,Yellow,Red,Yellow `
    -ValueForeColor ([Console]::ForegroundColor),Black,([Console]::ForegroundColor),Black


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