using System;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_02;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_10.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_ContactsDisplayedToConsole()
        {
            const string expected =
@"First NameLast Name    Phone       Address                       
Dick      Traci        123-123-1234123 Main St., Spokane, WA  99037

Title                                                    Author             Year
Celebration of Discipline                                Richard Foster     1978
Orthodoxy                                                G.K. Chesterton    1908
The Hitchhiker's Guide to the Galaxy                     Douglas Adams      1979
";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
    
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
