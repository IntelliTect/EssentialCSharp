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
    [Parameter(Mandatory,ParameterSetName="ChapterNumber")][int] $ChapterNumber,
    [Parameter()][int] $StartWithListing,
    [Parameter(Mandatory)][ValidateSet('Decrement','Increment')][string] $Direction
)


PROCESS {

    $listingNameRegEx = "Listing(?<Chapter>\d\d)\.(?<Listing>\d\d)(?<Suffix>.*)";
    Set-StrictMode -Version latest

    # TODO: Learning/verify:
    # $PSScriptRoot is not populated when you hover over it is ISE.
    # StrictMode has to be set after parameters if you are using CmdletBinding (perhaps regardless).

    $StartWithListing = $StartWithListing.ToString().PadLeft(2, '0')
    [string]$Chapter = $ChapterNumber.ToString().PadLeft(2, '0')
    
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
        "Increment"  { 
            $files | Sort -Descending
            $difference = 1
            break
        } 
    }

    $proj = [XML](Get-Content "$PSScriptRoot\Chapter$Chapter\Chapter$Chapter.csproj")

    foreach( $file in $Files) {
        $file -match $listingNameRegEx | %{  
            if($file.FullName -ne "$PSScriptRoot\Chapter$Chapter\$($matches[0])") { throw '$file unexpectedly doesn''t match $PSScriptRoot\Chapter$Chapter\$($matches[0])' }
            $oldFileName = $file.FullName
            $newFileName = "$PSScriptRoot\Chapter$Chapter\Listing$($matches.chapter).$(([int]::Parse($matches.listing) + $difference).ToString().PadLeft(2, '0'))$($matches.suffix)"
            $command = "git.exe mv `"$PSScriptRoot\Chapter$Chapter\$($matches[0])`" $newFileName $(if($PSBoundParameters['Verbose']) {`"-v`"})" # The following is not needed as it is handled by "$PSCmdlet.ShouldProcess": -What $(if($PSBoundParameters['WhatIf']) {`"--dry-run`"})"
            if ($PSCmdlet.ShouldProcess("`tExecuting: $command", "`tExecute git.exe Rename: $command", "Executing Git.exe mv")) {
                Invoke-Expression "$command"; 
            }
            if ($PSCmdlet.ShouldProcess(
                "`tUpdating Chapter$Chapter\Chapter$Chapter.csproj - Changing to compile '$([IO.Path]::GetFileName($newFileName))' rather than '$($file.Name)'",
                "`tUpdating Chapter$Chapter\Chapter$Chapter.csproj - Changing to compile '$([IO.Path]::GetFileName($newFileName))' rather than '$($file.Name)'",
                "Updating Chapter$Chapter\Chapter$Chapter.csproj:"
                )) {
                $proj.Project.ItemGroup.SelectNodes('//*[local-name()="Compile"]') | 
                    ?{ $_.Include -eq $file.Name }  | #Change to use XPath to find element as this makes no check that the element exists.
                        %{ $_.Include = [IO.Path]::GetFileName($newFileName) }
                $proj.Save("$PSScriptRoot\Chapter$Chapter\Chapter$Chapter.csproj") # Saving as each file is renamed rather than all at the end in case we error out in the middle.
            }
        }
    }
}