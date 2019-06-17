[CmdletBinding(SupportsShouldProcess)]
param($chapterNumber)
Get-ChildItems "Chapter$chapterNumber*.csproj" -Recurse | ForEach-Object {
    [xml]$csproj=Get-Content $_.FullName
    $csproj.Project.PropertyGroup.TargetFramework ='netcoreapp3.0'
    $nullable=$csproj.CreateElement('Nullable')
    $nullable.InnerXml = 'enable'
    $csproj.Project.PropertyGroup.AppendChild( $nullable )
    $langVersion = $csproj.CreateElement('LangVersion')
    $langVersion.InnerXml = '8.0'
    $csproj.Project.PropertyGroup.AppendChild( $langVersion )
    if ($PSCmdlet.ShouldProcess("Update csproj with netcoreapp3.0, Nullable, and LangVersion (8.0)", "Update csproj with netcoreapp3.0, Nullable, and LangVersion (8.0)")) {
        $csproj.Save("$($_.FullName)") #| Format-Xml | Compare-Object (Get-Content $_.FullName)
        get-content "$($_.FullName)"
    }
}