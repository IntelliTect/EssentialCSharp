using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_20.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_WriteMultiplePdaItemToScreen()
        {
            const string expected =
@"________
FirstName: Sherlock
LastName: Holmes
Address: 221B Baker Street, London, England

________
Subject: Soccer tournament
Start: 07/18/2008 00:00:00
End: 07/19/2008 00:00:00
Location: Estádio da Machava
________
FirstName: Anne
LastName: Frank
Address: Apt 56B, Whitehaven Mansions, Sandhurst Sq, London

";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}
