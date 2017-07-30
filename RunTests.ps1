[CmdletBinding()]
param(
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
        if(Test-IsOsPlatformWindows) { #Test because Write-Progress not working correctly on Ubunto on Windows.
            Write-Progress -Activity "Testing $Project..."
        }
        else {
            Write-Information -MessageData "Testing $Project..."
        }
        dotnet test $projectPath <#-p:BaseIntermediateOutputPath=$BaseIntermediateOutputPath#> | Tee-Object -FilePath $testOutputFilePath -Append |
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
            Write-Output ([PSCustomObject]$matchResult)
        } 
    }
}

Remove-Item -Path 'Test.Results.txt' -ErrorAction ignore
$format = "{0,-20}{1,10}{2,10}{3,10}{4,10}"
Write-Host ($format -f 'Project','Total','Passed','Failed','Skipped')
Get-ChildItem -recurse -include *.Tests.csproj -exclude IntelliTect.TestTools.Console.Tests.csproj | 
    Invoke-DotNetTest <#-BaseIntermediateOutputPath $BaseIntermediateOutputPath#> | ForEach-Object {
        if($_.Failed -gt 0) { 
            Write-Host "FAILED"
            $foregroundColor = [System.ConsoleColor]::Red
        } 
        else {
            if($_.Skipped -gt 0) {
                $foregroundColor = [System.ConsoleColor]::DarkYellow
            }
            else {
                $foregroundColor = [System.ConsoleColor]::Green
            }
        }
        Write-Host ($format -f $_.Project,$_.Total,$_.Passed,$_.Failed,$_.Skipped) -ForegroundColor $foregroundColor
    }