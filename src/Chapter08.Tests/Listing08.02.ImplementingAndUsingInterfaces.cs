using System;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_02
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_OutputListsOfContactsAndPublicationsToConsole()
        {
            const string expected =
@"First NameLast Name    Phone       Address                       
Dick      Traci        123-123-1234123 Main St., Spokane, WA  99037
Andrew    Littman      555-123-45671417 Palmary St., Dallas, TX 55555
Mary      Hartfelt     444-123-45671520 Thunder Way, Elizabethton, PA 44444
John      Lindherst    222-987-65431 Aerial Way Dr., Monteray, NH 88888
Pat       Wilson       123-456-7890565 Irving Dr., Parksdale, FL 22222
Jane      Doe          333-345-6789123 Main St., Aurora, IL 66666

Title                                                    Author             Year
The End of Poverty: Economic Possibilities for Our Time  Jeffrey Sachs      2006
Orthodoxy                                                G.K. Chesterton    1908
The Hitchhiker's Guide to the Galaxy                     Douglas Adams      1979
";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }

    [TestClass]
    public class ConsoleListControlTests
    {
        [TestMethod]
        public void DisplayHeaders_GivenContactHeaders_ProperWidthsReturned()
        {
            var widths = ConsoleListControl.DisplayHeaders(Contact.Headers);

            for (int i = 0; i < widths.Length; i++)
            {
                Assert.AreEqual(Contact.Headers[i].Length, widths[i]);
            }
        }

        [TestMethod]
        public void DisplayHeaders_GivenContactHeaders_HeadersWrittenToConsole()
        {
            const string expected =
@"First NameLast Name    Phone       Address                       ";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
                _ => { ConsoleListControl.DisplayHeaders(Contact.Headers); });
        }
        
        [TestMethod]
        [DataRow(new[]{1,2,3}, "v")]
        [DataRow(new[]{5,5,5}, "Name")]
        [DataRow(new[]{1,1,1}, "A")]
        public void DisplayItemRow_GivenWidthsLargerThanValues_ConsoleOutputToScreen(int[] widths, string value)
        {
            string[] values = Enumerable.Repeat(value, widths.Length).ToArray();
            var valuesIterator = values.GetEnumerator();

            valuesIterator.MoveNext();

            StringBuilder stringBuilder = new StringBuilder();
            widths.ToList().ForEach(width =>
            {
                stringBuilder.Append(valuesIterator.Current + new string(' ', 
                                         width - (valuesIterator.Current as string).Length));
                valuesIterator.MoveNext();
            });

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                stringBuilder.ToString(), _ => ConsoleListControl.DisplayItemRow(widths, values));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DisplayHeaders_GivenWidthsAndValuesOfDifferentLengths_ArgumentOutOfRangeException()
        {
            int[] widths = new int[10];
            string[] values = new string[5];
            
            ConsoleListControl.DisplayItemRow(widths, values);
        }
    }
}
