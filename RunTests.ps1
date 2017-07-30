[string]$testResultName = 'VisualStudio.TestTools.UnitTesting.TestResult'
Update-TypeData -TypeName $testResultName  -DefaultDisplayProperty Key -DefaultDisplayPropertySet Project,Total,Passed,Failed,Skipped -Force


Function Invoke-DotNetTest {
    [CmdletBinding()]
    param(
        [ValidateScript({ Test-Path $_})][parameter(Mandatory=$true, ValueFromPipelineByPropertyName=$true)][alias("Path","FullName")][string]$projectPath
    )
    PROCESS {  

        $project = (Get-Item $projectPath).BaseName
        $status = ""
        Write-Progress -Activity "Testing $Project..."
        dotnet test $projectPath | Tee-Object -FilePath Test.Results.txt |
        Where-Object { 
            if($_) { 
                #$status += "`t$_" 
                Write-Progress -Activity "Testing $Project..."  -Status $_
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

$format = "{0,-20}{1,10}{2,10}{3,10}{4,10}"
Write-Host ($format -f 'Project','Total','Passed','Failed','Skipped')
Get-ChildItem -recurse -include *.Tests.csproj -exclude IntelliTect.TestTools.Console.Tests.csproj | 
    Invoke-DotNetTest | ForEach-Object {
        if($_.Failed -gt 0) { 
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