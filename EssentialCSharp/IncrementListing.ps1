<#

.SYNOPSIS

Increments by 1 the Listing on file names using GIT


.DESCRIPTION


.PARAMETER Chapter 

The chapter you are incrementing the listings for.



.PARAMETER lowestListing

The lowest listing number you wish to increment.


.EXAMPLE

Increment all files after Listing13.06 relaying on the script to determine the specific files

IncrementListing.ps1 13 06


.EXAMPLE

Increment all files starting with Listing13.06:

Get-Item .\Chapter13\Listing13* | IncrementListing.ps1 13 06
#>

[CmdletBinding(SupportsShouldProcess=$True)]
param(
    [Parameter(Mandatory)][string] $Chapter,
    [Parameter(Mandatory)][string] $LowestListing,
    [Parameter(ValueFromPipeline)][string[]] $Files
)



PROCESS {
    Set-StrictMode -Version latest

    # TODO: Learning/verify:
    # $PSScriptRoot is not populated when you hover over it is ISE.
    # StrictMode has to be set after parameters if you are using CmdletBinding (perhaps regardless).

    $LowestListing = $LowestListing.PadLeft(2, '0')

    if($Files -eq $null) {
        $Files = (dir "$PSScriptRoot\Chapter$Chapter" "Listing*" | ?{ 
            $_.Name -ge "Listing$Chapter.$LowestListing" } | 
                sort -Descending)
    }
    foreach( $file in $Files) {
        $file -match "Listing(?<chapter>\d\d)\.(?<listing>\d\d)(?<suffix>.*)" | ?{ 
            if($matches.listing -ge $LowestListing) {$true}
            else {
                Write-Warning "$File is ignored because it is less than the lowest listing ($LowestListing)."
            }
        } | %{  
            $command = "git.exe mv $(if($PSBoundParameters['Verbose']) {`"-v`"}) `"$PSScriptRoot\Chapter$Chapter\$($matches[0])`" `"$PSScriptRoot\Chapter$Chapter\Listing$($matches.chapter).$(([int]::Parse($matches.listing) + 1).ToString().PadLeft(2, '0'))$($matches.suffix)`" "
            if ($PSCmdlet.ShouldProcess("`tExecuting: $command", "`tExecute git.exe Rename: $command", "Executing Git.exe mv")) {
                Invoke-Expression "$command"; 
            }
        }
    }
}