[CmdletBinding(SupportsShouldProcess)]
param($chapterNumber)
$chapterNumber | Foreach-Object{
  $projects = Get-ChildItem "Chapter$_*.csproj" -Recurse | Select-Object -ExpandProperty FullName  | Sort-Object -Descending
  $projects | Write-Host -ForegroundColor Magenta
  $projects | Foreach-Object{
      git checkout $_
      return
      Get-ChildItem (split-path $_ -Parent) obj | remove-item -Recurse -Force -ErrorAction SilentlyContinue
      dotnet clean $_  ;
  }
  $projects | Where-Object{ $_ -like '*Tests.*' } | %{
      return
      dotnet test $_
  }
  $projects | Foreach-Object{
      Update-CSProjectFileToCSharp8 -csprojFilePath $_
      nukeeper update  --useprerelease Always --change Major --maxpackageupdates 100 -v D (split-path $_ -Parent)
      Get-ChildItem (split-path $_ -Parent) obj | remove-item -Recurse -Force -ErrorAction SilentlyContinue
      dotnet clean $_  ;
  }
  $projects | ?{ $_ -like '*Tests.*' } | Foreach-Object{
      dotnet test $_
  }
}