using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_12.Tests
{
    [TestClass]
    public class TextNumberParserTests
    {
        [TestMethod]
        public void Main_InigoMontoya_Success()
        {
            const string expected =
                @"Hello Inigo Montoya.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, (Action<string[]>)(Program.Main), "Inigo Montoya" );
        }
        [TestMethod]
        public void Main_InigoMontoyaWithGreeting_Success()
        {
            const string expected =
                @"Hello Inigo Montoya.  Welcome!";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, (Action<string[]>)(Program.Main), "Inigo Montoya", "-g", "Hello {name}.  Welcome!");
        }

        [TestMethod]
        public void Main_GreetingWithInigoMontoya_Success()
        {
            const string expected =
                @"Hello Inigo Montoya.  Welcome!";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, (Action<string[]>)(Program.Main), "-g", "Hello {name}.  Welcome!", "Inigo Montoya");
        }

        [TestMethod]
        public void Main_OptionQuestionMark_Success()
        {
            const string expected =
                @"

Usage:  [arguments] [options]

Arguments:
  name  Enter the full name of the person to be greeted.

Options:
  -$|-g |--greeting <greeting>  The greeting to display. The greeting supports a format string where '{name}' will be substituted with the name.
  -? | -h | --help              Show help information

Hello .";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, (Action<string[]>)(Program.Main), "-?");
        }
    }
}