Set-StrictMode -Version Latest

$script:listingNameRegEx = "Listing(?<Chapter>\d\d)\.(?<Listing>\d\d)(?<Suffix>.*)";

Function script:Move-GitFile {
    [CmdletBinding(SupportsShouldProcess=$True)] 
    param(
        [ValidateScript({Test-Path $_ -PathType Leaf})][Parameter(Mandatory)][string]$oldFileName,
        [ValidateScript({!(Test-Path $_ -PathType Leaf)})][Parameter(Mandatory)][string]$newFileName
    )

    #TODO: Verify that git is the SCC tool.

    $command = "git mv $oldFileName $newFileName $(if($PSBoundParameters['Verbose']) {`"-v`"})" # The following is not needed as it is handled by "$PSCmdlet.ShouldProcess": -What $(if($PSBoundParameters['WhatIf']) {`"--dry-run`"})"
    if ($PSCmdlet.ShouldProcess("`tExecuting: $command", "`tExecute git.exe Rename: $command", "Executing Git.exe mv")) {
        Invoke-Expression "$command" -ErrorAction Stop  #Change error handling to use throw instead.
    }
}

Function script:Update-ListingNumberInContent {
[CmdletBinding(SupportsShouldProcess=$True)] 
    param(
        [ValidateScript({Test-Path $_ -PathType Leaf})][Parameter(Mandatory)][string]$Path,
        [Parameter(Mandatory)][string]$ChapterNumber,
        [string]$NewChapterNumber = $ChapterNumber,
        [Parameter(Mandatory)][string]$ListingNumber,
        [Parameter(Mandatory)][string]$NewListingNumber
    )

    if(!$NewChapterNumber) { $NewChapterNumber = $ChapterNumber}


    $process = $PSCmdlet.ShouldProcess("`tSearch/Replace Listing $ChapterNumber.$ListingNumber to $NewChapterNumber.$NewListingNumber", 
        "`tSearch/Replace Listing $ChapterNumber.$ListingNumber to $NewChapterNumber.$NewListingNumber", "Search/Replace Listing")

    $changes = @();
    $newContent = (Get-Content $Path) | ForEach-Object{
        $after = $_.Replace("Chapter$ChapterNumber.","Chapter$NewChapterNumber.")
        $after = $after.Replace("Listing$($ChapterNumber)_$ListingNumber","Listing$($NewChapterNumber)_$NewListingNumber")
        if($_ -ne $after) {
            $changes += ([pscustomobject]@{Before = $_; After = $after})
        }
        Write-Output $after
    }
    [int] $maxBeforeWidth = 0
    [int] $maxAfterWidth = 0
    [string] $messageLine = $null
    $changes | ForEach-Object {
        $maxBeforeWidth = [Math]::Max($maxBeforeWidth, $_.Before.Length)
        $maxAfterWidth = [Math]::Max($maxAfterWidth, $_.After.Length)
    }
    $changes | ForEach-Object {
        $messageLine += "`t`t{0,-$maxBeforeWidth}`t{1,-$maxAfterWidth}" -f $_.Before,$_.After
    }
    
    if($PSCmdlet.ShouldProcess("$messageLine", "$messageLine", "Search/Replace Listing")) {
        $newContent | Set-Content $path
    }
}

Function Update-ListingNumber {
[CmdletBinding(SupportsShouldProcess=$True)] 
    param(
        [Parameter(Mandatory)][string]$ChapterNumber,
        [string]$NewChapterNumber,
        [Parameter(Mandatory)][string]$ListingNumber,
        [Parameter(Mandatory)][string]$NewListingNumber
    )

    if(!$NewChapterNumber) { $NewChapterNumber = $ChapterNumber}

    $oldFilePathPattern = (Join-Path (Join-Path $PSScriptRoot "Chapter$ChapterNumber") "Listing$ChapterNumber.$ListingNumber*.cs")
    $files = @(Get-Item $oldFilePathPattern)

    Function script:Update-ListingNumber {
        [CmdletBinding(SupportsShouldProcess=$true)]
        param(
            $files
        )
        $files | ForEach-Object{
            $oldFilePath = $_.FullName
            $newFilePath = $oldFilePath -replace "Listing$ChapterNumber.$ListingNumber","Listing$NewChapterNumber.$NewListingNumber"
            $oldFilePath = $oldFilePath.Replace("$pwd",".")  #Shorten to use the relative path
            script:Update-ListingNumberInContent -Path $oldFilePath `
                -ChapterNumber $ChapterNumber -NewChapterNumber $NewChapterNumber `
                -ListingNumber $ListingNumber -NewListingNumber $NewListingNumber
            script:Move-GitFile $oldFilePath $newFilePath
        }        
    }

    if(!$files) {
        throw "The file, '$oldFilePAth', does not exist"
    }
    else {
        script:Update-ListingNumber $files
    }

    # Repeat for the test file except allow for the file not to exist.
    $oldFilePathPattern = (Join-Path (Join-Path $PSScriptRoot "Chapter$ChapterNumber.Tests") "Listing$ChapterNumber.$ListingNumber*.cs")
    $files = Get-Item $oldFilePathPattern
    if($files) {
        script:Update-ListingNumber $files
    }
}




return

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


<#
[CmdletBinding(SupportsShouldProcess=$True)] 
param(
    [Parameter(Mandatory,ValueFromPipeline,ParameterSetName="Files")][string[]] $Files,
    [Parameter(Mandatory,ParameterSetName="ChapterNumber")][int] $ChapterNumber,
    [Parameter()][string] $StartWithListing,
    [Parameter()][string] $EndWithListing,
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
        $StartWithListing = $StartWithListing.Split(".")[1]
    }
    if( ($EndWithListing -like "*.*")) { # Remove Chapter prefix if it exists.
        $EndWithListing = $EndWithListing.Split(".")[1]
    }

    $StartWithListing = $StartWithListing.ToString().PadLeft(2, '0')
    $EndWithListing = $EndWithListing.ToString().PadLeft(2, '0')
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
    $Files = $Files | ?{ $_.Name -le "Listing$Chapter.$EndWithListing" }

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

#>