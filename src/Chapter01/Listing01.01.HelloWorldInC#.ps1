Function Invoke-SampleHelloWorld {
    Clear-Host
    $expression = @"
New-Item -ItemType Directory ./HelloWorld
Set-Location ./HelloWorld/
dotnet new console
dotnet run
"@ -split '`n'
    $expression += @"
@'
class HelloWorld
{
 static void Main()
 {
   System.Console.WriteLine("Hello. My name is Inigo Montoya.");
 }
}
'@ > Program.cs
"@

    $expression +=
@'
dotnet run
'@ -split '`n'

    $expression | %{
        Write-Host ">$_" -ForegroundColor Yellow;
        Invoke-Expression $_ }
}
Set-Location $PSScriptRoot; Remove-Item .\HelloWorld -Recurse
Invoke-SampleHelloWorld