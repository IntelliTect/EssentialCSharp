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
    [Parameter()][string] $StartWithListing,
    [Parameter(Mandatory)][ValidateSet('Decrement','Increment')][string] $Direction
)

PROCESS {

    Set-StrictMode -Version latest

    if(!(Test-Path Function:Rename-CompileFile)) {
        #Define if it doesn't exists
        Function Script:Rename-CompileFile {
            [CmdletBinding(SupportsShouldProcess=$true)] param(
                    [ValidateScript({Test-Path $_ -PathType Leaf})][Parameter(Mandatory)][string] $projFile, 
                    [ValidateScript({Test-Path $_ -PathType Leaf})][Parameter(Mandatory)][string] $oldFileName,
                    [Parameter(Mandatory)][string] $newFileName
            )

            #TODO: Verify that git is the SCC tool.
            #TODO: Add support for TFS.

            $command = "git.exe mv $oldFileName $newFileName $(if($PSBoundParameters['Verbose']) {`"-v`"})" # The following is not needed as it is handled by "$PSCmdlet.ShouldProcess": -What $(if($PSBoundParameters['WhatIf']) {`"--dry-run`"})"
            if ($PSCmdlet.ShouldProcess("`tExecuting: $command", "`tExecute git.exe Rename: $command", "Executing Git.exe mv")) {
                Invoke-Expression "$command" -ErrorAction Stop  #Change error handling to use throw instead.
            }
            $projFile = Resolve-Path $projFile
            $proj = [XML](Get-Content $projFile)
            #TODO Add support for subdirectories in the VS path.
            $proj.Project.ItemGroup.SelectNodes('//*[local-name()="Compile"]') | 
                ?{ $_.Include -eq [IO.Path]::GetFileName($oldFileName) }  | #TODO: Change to use XPath to find element as this makes no check that the element exists.
                    %{ $_.Include = [IO.Path]::GetFileName($newFileName) }
            if ($PSCmdlet.ShouldProcess(
                "`tUpdating $projFile - Renaming compiled file '$([IO.Path]::GetFileName($oldFileName))' to '$([IO.Path]::GetFileName($newFileName))'",
                "`tUpdating $projFile - Renaming compiled file '$([IO.Path]::GetFileName($oldFileName))' to '$([IO.Path]::GetFileName($newFileName))'",
                "Updating $($projFile):"
                )) {
                $proj.Save($projFile) # Saving as each file is renamed rather than all at the end in case we error out in the middle.
            }
        }
    }

    $listingNameRegEx = "Listing(?<Chapter>\d\d)\.(?<Listing>\d\d)(?<Suffix>.*)";

    # TODO: Learning/verify:
    # $PSScriptRoot is not populated when you hover over it is ISE.
    # StrictMode has to be set after parameters if you are using CmdletBinding (perhaps regardless).
 
    if( ($StartWithListing -like "*.*")) { # Remove Chapter prefix if it exists.
        $startWithListing = $StartWithListing.Split(".")[1]
    }

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

    #$proj = [XML](Get-Content "$PSScriptRoot\Chapter$Chapter\Chapter$Chapter.csproj")

    foreach( $file in $Files) {
        $file -match $listingNameRegEx | %{  
            $oldFileName = $file.FullName  #Same as $PSScriptRoot\Chapter$Chapter\$($matches[0])
            $newFileName = "$PSScriptRoot\Chapter$Chapter\Listing$($matches.chapter).$(([int]::Parse($matches.listing) + $difference).ToString().PadLeft(2, '0'))$($matches.suffix)"
            Rename-CompileFile -projFile "$PSScriptRoot\Chapter$Chapter\Chapter$Chapter.csproj" -oldFileName $oldFileName -newFileName $newFileName

            #Check for corresponding test file.
            $testFileFilter = "$PSScriptRoot\Chapter$Chapter.Tests\Listing$($matches.chapter).$(($matches.listing).ToString().PadLeft(2, '0'))*.Tests.cs"
            if(Test-Path $testFileFilter) {
                $oldTestFileName = (Get-Item $testFileFilter).FullName
                $newTestFileName = 
                    Join-Path "$PSScriptRoot\Chapter$Chapter.Tests" `
                        ([io.path]::ChangeExtension( [io.path]::GetFileName( $newFileName ), "Tests.cs"))
                $testProjectFile = [IO.Path]::ChangeExtension("$PSScriptRoot\Chapter$Chapter.Tests\Chapter$Chapter.csproj", "Tests.csproj")
                Rename-CompileFile -projFile $testProjectFile -oldFileName $oldTestFileName -newFileName $newTestFileName
            }
        }
    }
}

