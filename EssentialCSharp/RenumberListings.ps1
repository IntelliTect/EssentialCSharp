<#

.SYNOPSIS

Increments or decrements files by 1 starting with the first listing specified.


.DESCRIPTION


.PARAMETER StartWithChapterListing

The lowest listing to start with.



.PARAMETER Direction

Whether to increment or decrement the count.


.EXAMPLE

IncrementDecrement files stari all files after Listing13.06 relaying on the script to determine the specific files

IncrementListing.ps1 13 06


.EXAMPLE

Increment all files starting with Listing13.06:

Get-Item .\Chapter13\Listing13* | IncrementListing.ps1 13 06
#>

[CmdletBinding(SupportsShouldProcess=$True)]
param(
    [Parameter(Mandatory,ValueFromPipeline,ParameterSetName="Files")][string[]] $Files,
    [Parameter(Mandatory,ParameterSetName="ChapterNumber")][int] $Chapter,
    [Parameter()][string] $StartWithListing,
    [Parameter(Mandatory)][ValidateSet('Decrement','Increment')][string] $Direction
)


PROCESS {

    $listingNameRegEx = "Listing(?<Chapter>\d\d)\.(?<Listing>\d\d)(?<Suffix>.*)";
    Set-StrictMode -Version latest

    # TODO: Learning/verify:
    # $PSScriptRoot is not populated when you hover over it is ISE.
    # StrictMode has to be set after parameters if you are using CmdletBinding (perhaps regardless).

    $StartWithListing = $StartWithListing.PadLeft(2, '0')

    switch($PsCmdlet.ParameterSetName)
    {
        "ChapterNumber" {
            [IO.FileInfo[]]$Files = Get-ChildItem "$PSScriptRoot\Chapter$Chapter" "Listing*" -File
        }
        "Files" {
            $Files[0] -match $listingNameRegEx
            $Chapter = $Matches.Chapter
        }
    }

    $Files = $Files | ?{ $_.Name -ge "Listing$Chapter.$StartWithListing" }

    $difference = 0;
    $files = switch ($Direction) { 
        "Decrement"  { 
            $files | Sort
            $difference = -1
            break
        } 
        "Decrement"  { 
            $files | Sort -Descending
            $difference = 1
            break
        } 
    }

    foreach( $file in $Files) {
        $file -match $listingNameRegEx | %{  
            $command = "git.exe mv `"$PSScriptRoot\Chapter$Chapter\$($matches[0])`" `"$PSScriptRoot\Chapter$Chapter\Listing$($matches.chapter).$(([int]::Parse($matches.listing) + $difference).ToString().PadLeft(2, '0'))$($matches.suffix)`" $(if($PSBoundParameters['Verbose']) {`"-v`"}) $(if($PSBoundParameters['WhatIf']) {`"--dry-run`"})"
            if ($PSCmdlet.ShouldProcess("`tExecuting: $command", "`tExecute git.exe Rename: $command", "Executing Git.exe mv")) {
                Invoke-Expression "$command"; 
            }
        }
    }
}