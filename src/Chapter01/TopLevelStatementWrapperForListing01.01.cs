// See https://aka.ms/new-console-template for more information
// this file redirects debug break points to Listing01.01.HelloWorldInC#.cs
// allowing for the appearance that the top-level statement file of Listing01.01.HelloWorldInC#.cs is what is being ran.
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_01;

public class HelloWorld
{
    public static void Main()
    {
        // the #line directive reroutes the debugger's line mapper from this file to "Listing01.01.HelloWorldInC#.cs"
        // see https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/preprocessor-directives#error-and-warning-information
#line (3,1) - (3,55) 13 "Listing01.01.HelloWorldInC#.cs"
        Console.WriteLine("Hello. My name is Inigo Montoya.");
    }
}