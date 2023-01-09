
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_32.Tests;

[TestClass]
public class ProgramTests
{

    [TestMethod]
    [DataRow("help")]
    [DataRow("h")]
    [DataRow("?")]
    [DataRow("<invalid>")]
    public void ParseHelpCommand(string command)
    {
        foreach (string item in PrefixCommands(command))
        {
            command = $"{item}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                "Command Help...", () => Program.Main(command));
        }
    }

    [TestMethod]
    [DataRow("cat", @"..\SampleFile.txt")]
    [DataRow("c", @"..\SampleFile.txt")]
    public void ParseCatCommand(string command, string fileName)
    {
        foreach (string item in PrefixCommands(command))
        {
            command = $"{item}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                $"Catalog '{fileName}'...", () => Program.Main(command, fileName));
        }
    }


    [TestMethod]
    [DataRow("copy", @"..\source.txt", @"..\target.txt")]
    public void ParseCopyCommand(string command, string sourceFile, string targetFile)
    {
        foreach (string item in PrefixCommands(command))
        {
            command = $"{item}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                $"Copy '{sourceFile}' '{targetFile}'...", () => Program.Main(command, sourceFile, targetFile));
        }
    }

    private static List<string> PrefixCommands(string command)
    {
        List<string> commands = new();

        string[] shortPrefix = new[] { "/", "-" };

        if (command.Length == 1)
        {
            foreach (string item in shortPrefix)
            {
                commands.Add($"{item}{command}");
            }
        }
        else
        {
            commands.Add($"--{command}");
        }
        return commands;
    }


}
