$Passed = 0;
$Failed = 0;
$Skipped = 0;

$lines = Get-Content Test.Results.txt | Where {$_ -match '^.*tests: (.*)\..*$'} 
foreach ($line in $lines)
{
	if($line -ne '')
	{
	    $resultLine = $line.Split('.')
	    foreach($result in $resultLine)
	    {
		    if($result -ne '')
		    {
		        $split = $result.Split(':')
		        #Write-Host $split[1] ":" $split[0].Trim()
                if($split[0].Trim() -eq 'Passed')
                {
                    $Passed += $split[1].Trim();
                }
                if($split[0].Trim() -eq 'Failed')
                {
                    $Failed += $split[1].Trim();
                }
                if($split[0].Trim() -eq 'Skipped')
                {
                    $Skipped += $split[1].Trim();
                }
		    }
	    }

        $Total = $Passed + $Failed + $Skipped;
        if($Failed -gt 0)
        {
            Write-Host "Total:" $Total ", Passed:" $Passed ", Failed:" $Failed ", Skipped:" $Skipped -ForegroundColor Red
        }
        elseif($Skipped -gt 0)
        {
            Write-Host "Total:" $Total ", Passed:" $Passed ", Failed:" $Failed ", Skipped:" $Skipped -ForegroundColor Yellow
        }
        else
        {
            Write-Host "Total:" $Total ", Passed:" $Passed ", Failed:" $Failed ", Skipped:" $Skipped -ForegroundColor Green
        }
	}
}

