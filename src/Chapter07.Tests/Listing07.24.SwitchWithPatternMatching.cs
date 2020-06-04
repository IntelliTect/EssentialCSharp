using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_24
{
    [TestClass]
    public class ProgramTests
    {
        const string format = "{0:0000}{1:00}{2:00}";
        const string expected = "20200202";

        [TestMethod]
        public void CompositeFormatDate_GivenDateTime_Return20200202()
        {
            Assert.AreEqual<string?>(
                expected, Program.CompositeFormatDate(
                    new DateTime(2020, 2, 2), format));
        }
        [TestMethod]
        public void CompositeFormatDate_GivenDateTimeOffset_Return20200202()
        {
            Assert.AreEqual<string?>(
                expected, Program.CompositeFormatDate(
                    new DateTimeOffset(new DateTime(2020, 2, 2), new TimeSpan()), format));
        }

        [TestMethod]
        public void CompositeFormatDate_GivenDateString_Return20200202()
        {
            Assert.AreEqual<string?>(
                expected, Program.CompositeFormatDate(
                    "2020-02-02", format));
        }

        [TestMethod]
        public void CompositeFormatDate_GivenBogusString_ReturnNull()
        {
            Assert.IsNull(Program.CompositeFormatDate(
                    "bogus", format));
        }
    }
}
