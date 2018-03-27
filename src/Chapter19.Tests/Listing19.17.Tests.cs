using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_17.Tests
{
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void AsyncVoidReturnTest()
        {

            string expected = $@"Invoking Task.Run...(Thread ID: *)
Running task... (Thread ID: *)
Post notification invoked...(Thread ID: *)
Post notification invoked...(Thread ID: *)
Throwing expected exception....(Thread ID: *)
System.Exception: Expected Exception
   at AddisonWesley.Michaelis.EssentialCSharp.Chapter18.{nameof(Listing18_17)}.Program.Main() in *{nameof(Listing18_17).Replace('_','.')}.AsyncVoidReturn.cs:line * thrown as expected.(Thread ID: *)";

            string output = IntelliTect.TestTools.Console.ConsoleAssert.ExpectLike(expected,
            () =>
            {
                Program.Main();
            });

            Console.WriteLine(output);

            // Verify that only the 'Running task...' thread id (the second line), is unique
            MatchCollection matches = Regex.Matches(output, @"\(Thread ID: (\d)+\)");
            int firstThreadId = int.Parse(matches[0].Groups[1].Value);
            for (int i = 0; i < matches.Count; i++)
            {
                if(i == 1)
                {
                    Assert.AreNotEqual<int>(firstThreadId, int.Parse(matches[i].Groups[1].Value));
                }
                else
                {
                    Assert.AreEqual<int>(firstThreadId, int.Parse(matches[i].Groups[1].Value));
                }
            }
            Assert.AreEqual<int>(6, matches.Count, "There were not as many 'Thread Id' matches as expected.");
        }
    }
}
