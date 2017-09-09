Function Invoke-SampleHelloWorld {
    cls
    $expression = @"
mkdir ./HelloWorld
cd ./HelloWorld/
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
cd $PSScriptRoot; rmdir .\HelloWorld -Recurse
Invoke-SampleHelloWorld