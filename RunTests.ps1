[CmdletBinding()]
param(
    [string[]]$Chapter='*',
    $BaseIntermediateOutputPath="obj$([System.IO.Path]::DirectorySeparatorChar)"
)


[string]$testResultName = 'VisualStudio.TestTools.UnitTesting.TestResult'
Update-TypeData -TypeName $testResultName  -DefaultDisplayProperty Key -DefaultDisplayPropertySet Project,Total,Passed,Failed,Skipped -Force

Function Test-IsOsPlatformWindows {
    [CmdletBinding()]
    param(
        #[ValiateSet('Windows','Linux','Mac')][string]$OsPlatform
    )
    return ( ('System.Runtime.InteropServices.RuntimeInformation' -as [Type]) -and
        [System.Runtime.InteropServices.RuntimeInformation]::IsOSPlatform(
            [System.Runtime.InteropServices.OSPlatform]::Windows) )
} 

Function Invoke-DotNetTest {
    [CmdletBinding()]
    param(
        [ValidateScript({ Test-Path $_})][parameter(Mandatory=$true, ValueFromPipelineByPropertyName=$true)][alias("Path","FullName")][string]$projectPath,
        [string]$testOutputFilePath = 'Test.Results.txt',
        [string]$BaseIntermediateOutputPath = "obj$([System.IO.Path]::DirectorySeparatorChar)"
    )
    PROCESS {  

        $project = (Get-Item $projectPath).BaseName
        $status = ""
        [string]$testResults = @();
        if(Test-IsOsPlatformWindows) { #Test because Write-Progress not working correctly on Ubunto on Windows.
            Write-Progress -Activity "Testing $Project..."
        }
        else {
            Write-Information -MessageData "Testing $Project..."
        }
        dotnet test $projectPath <#-p:BaseIntermediateOutputPath=$BaseIntermediateOutputPath#> 2>$null <# Ignore error output as it is captured in the log anyway. #> | 
            Tee-Object -FilePath $testOutputFilePath -Append |
        Where-Object { 
            if($_) { 
                if(Test-IsOsPlatformWindows) { #Test because Write-Progress not working correctly on Ubunto on Windows.
                    Write-Progress -Activity "Testing $Project..."  -Status $_
                }
                else {
                    Write-Information -MessageData "`t$_" 
                }
            }
            $match = $_  -match (-join ('Total tests','Passed','Failed','Skipped' | 
                ForEach-Object{ "\s?$($_):\s?(?<$($_ -replace 'Total tests','Total')>[0-9]+)\.\s?,?"} ));

            $matchResult = $matches
            Write-Output $match
        } | 
        ForEach-Object{
            $matchResult.Add("Key", $matchResult.0)
            $matchResult.Add("Project", $project)
            $matchResult.Add("PSTypeName", $testResultName)
            $matchResult.Add("TestResultDetail", $testResults)
            Write-Output ([PSCustomObject]$matchResult)
        } 
    }
}


Remove-Item -Path 'Test.Results.txt' -ErrorAction ignore
[string[]]$chapters=$null
if($Chapter -ne '*' ) {
    $chapters = ($Chapter | ForEach-Object{ "$_".PadLeft(2, '0')} | ForEach-Object{ "*$_.Tests.csproj" })
}
else {
    $chapters = '*.Tests.csproj'
}


$testResults = $()
$chapterProjects = @(Get-ChildItem -recurse -include $chapters -exclude IntelliTect.TestTools.Console.Tests.csproj)
if($chapterProjects.Count -gt 0) {
    $format = "{0,-20}{1,10}{2,10}{3,10}{4,10}"
    Write-Host ($format -f 'Project','Total','Passed','Failed','Skipped')
    Write-Host ($format -f '-------','-----','------','------','-------')

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
