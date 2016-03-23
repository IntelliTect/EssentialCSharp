using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntelliTect.ConsoleView.Tests
{
    [TestClass]
    public class TesterTests
    {
        [TestMethod]
        public void ConsoleView_Sample_InigoMontoya()
        {
            string view =
@"First name: <<Inigo
>>Last name: <<Montoya
>>Hello, Inigo Montoya.";

            IntelliTect.ConsoleView.Tester.Test(view,
            () =>
            {
                System.Console.Write("First name: ");
                string fname = System.Console.ReadLine();

                System.Console.Write("Last name: ");
                string lname = System.Console.ReadLine();

                System.Console.Write("Hello, {0} {1}.", fname, lname);
            });
        }

        [TestMethod]
        public void ConsoleView_HelloWorld_NoInput()
        {
            string view = @"Hello World";

            IntelliTect.ConsoleView.Tester.Test(view, () =>
            {
                System.Console.Write("Hello World");
            });
        }

        [TestMethod]
        public void ConsoleView_HelloWorld_MissingNewline()
        {
            string view = @"Hello World";

            IntelliTect.ConsoleView.Tester.Test(view, () =>
            {
                System.Console.WriteLine("Hello World");
            });
        }


        [TestMethod]
        public void ExecuteProcess_PingLocalhost_Success()
        {
            ConsoleView.Tester.ExecuteProcess(
$@"
Pinging { Environment.MachineName } * with 32 bytes of data:
Reply from *: time*", 
                "ping.exe", "localhost");
        }
    }
}