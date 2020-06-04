using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_17
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_WriteMultiplePdaItemToScreen()
        {
            DateTime startDateTime = new DateTime(2008, 7, 18);
            DateTime endDateTime = startDateTime.AddDays(1);

            string expected =
$@"________
FirstName: Sherlock
LastName: Holmes
Address: 221B Baker Street, London, England

________
Subject: Soccer tournament
Start: {startDateTime}
End: {endDateTime}
Location: Estádio da Machava
________
FirstName: Anne
LastName: Frank
Address: Apt 56B, Whitehaven Mansions, Sandhurst Sq, London" + Environment.NewLine + Environment.NewLine;

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}
