using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_17.Tests
{
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ProgramTests
    {

        string TargetNamespaceName { get { return typeof(Program).Namespace; } }

        [TestMethod]
        public void AsyncVoidReturnTest()
        {
            string expected = $@"Invoking Task.Run...(Thread ID: *)
Running task... (Thread ID: *)
Post notification invoked...(Thread ID: *)
Post notification invoked...(Thread ID: *)
Throwing expected exception....(Thread ID: *)
System.Exception: Expected Exception
   *(Thread ID: *)";

            string output = IntelliTect.TestTools.Console.ConsoleAssert.ExpectLike(expected,
            () =>
            {
                Program.Main();
            });

            Console.WriteLine(output);

            // Verify that only the 'Running task...' thread id (the second line), is unique
            MatchCollection matches = Regex.Matches(output, @"\(Thread ID: (\d)+\)");
            int firstThreadId = int.Parse(matches[0].Groups[1].Value);
            int secondThreadId = int.Parse(matches[1].Groups[1].Value);
            int? expectedThreadId;
            for (int i = 0; i < matches.Count; i++)
            {
                switch (i)
                {
                    case 0:
                    case 4:
                    case 5:
                        expectedThreadId = firstThreadId;
                        break;
                    case 1:
                        // Obviously
                        expectedThreadId = secondThreadId;
                        break;
                    default:
                        // Unknown
                        expectedThreadId = null;
                        break;
                }
                if (expectedThreadId != null)
                {
                    Assert.AreEqual<int?>(expectedThreadId, int.Parse(matches[i].Groups[1].Value),
                        $"Match {i} was '{matches[i].Groups[0].Value}' when '{expectedThreadId}' was expected");
                }
            }
            Assert.AreEqual<int>(6, matches.Count, "There were not as many 'Thread Id' matches as expected.");
        }
    }
}
