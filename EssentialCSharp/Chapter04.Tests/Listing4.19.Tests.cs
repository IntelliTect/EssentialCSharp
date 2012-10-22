using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_19.Tests
{
    [TestClass]
    public class ExceptionHandlingTests
    {
        [TestMethod]
        public void Main_InputNameAge_ExpectMonthCount()
        {
            string view =
@"Hey you!
Enter your first name: <<Inigo
>>Enter your age: <<10
>>Hi Inigo!  You are 120 months old.";

            IntelliTect.ConsoleView.Tester.Test(view,
            () =>
            {
                ExceptionHandling.Main();
            });
        }
    }
}