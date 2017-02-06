$root = "C:\src\Intellitect\EssentialCSharp\src"



$files = Get-ChildItem -Recurse "$root\*.csproj"
foreach($file in $files){
$projectName = $file.Name.Replace(".csproj", "")
if($file.Name.Contains("Test"))
{
$text = "<Project Sdk=""Microsoft.NET.Sdk"">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp1.0</TargetFramework>
    <ProductName>$projectName</ProductName>
  </PropertyGroup>
  <Import Project=""..\Versioning.targets"" />
  <ItemGroup>
    <PackageReference Include=""Microsoft.NET.Test.Sdk"" Version=""15.0.0-preview-20170106-08"" />
    <PackageReference Include=""MSTest.TestAdapter"" Version=""1.1.8-rc"" />
    <PackageReference Include=""MSTest.TestFramework"" Version=""1.0.8-rc"" />
  </ItemGroup>
</Project>"


}
else
{
$text = "<Project Sdk=""Microsoft.NET.Sdk"">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp1.0</TargetFramework>
    <ProductName>$projectName</ProductName>
  </PropertyGroup>
  <Import Project=""..\Versioning.targets"" />
  <ItemGroup>
    <ProjectReference Include=""..\SharedCode\SharedCode.csproj"" />
  </ItemGroup>
</Project>"
}

$text > $file.FullName

    Write-Host $file.Name.Replace(".csproj", "")
}

