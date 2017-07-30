[string]$testResultName = 'VisualStudio.TestTools.UnitTesting.TestResult'
Update-TypeData -TypeName $testResultName  -DefaultDisplayProperty Key -DefaultDisplayPropertySet Chapter,Total,Passed,Failed,Skipped -Force

Get-ChildItem -recurse -include *.Tests.csproj |  
    ForEach-Object { 
        $project = $_.BaseName
        $status = ""
        Write-Progress -Activity "Testing $Project..."
        dotnet test $_} | Tee-Object -FilePath Test.Results.txt |
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
