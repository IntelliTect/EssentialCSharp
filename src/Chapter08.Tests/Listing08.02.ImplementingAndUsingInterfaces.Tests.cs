using System;
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
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void List_HeadersAndItemsNotOfSameLength_ArgumentOutOfRangeException()
        {
            IListable[] contacts = {
                new Contact(
                    "Dick", "Traci",
                    "123 Main St., Spokane, WA  99037",
                    "123-123-1234")
            };
            ConsoleListControl.List(new[]{"Header1", "Header2"}, contacts);
        }

        [TestMethod]
        public void List_NoItemsInArray_HeadersProperlyDisplayed()
        {
            IListable[] contacts = {};

            string expected = "Header1Header2";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, _ => { ConsoleListControl.List(new[] {"Header1", "Header2"}, contacts); });
        }

        [TestMethod]
        public void List_SingleItemInArrayUsingContactHeaders_ItemProperlyDisplayed()
        {
            IListable[] contacts =
            {
                new Contact(
                    "Inigo", "Montoya",
                    "123 Main St., Spokane, WA 99037",
                    "123-123-1234")
            };

            const string expected =
@"First NameLast Name    Phone       Address                       
Inigo     Montoya      123-123-1234123 Main St., Spokane, WA 99037";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, _ => { ConsoleListControl.List(Contact.Headers, contacts); });
        }
    }
}
