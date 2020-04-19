using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_01.Tests
{
    [TestClass]
    public class TextNumberParserTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Parse_GivenNull_ThrowsArgumentNullException()
        {
            TextNumberParser.Parse(null!);
        }

        [TestMethod]
        public void Parse_GivenOne_Returns1()
        {
            Assert.AreEqual<int>(1, TextNumberParser.Parse("one"));
        }
    }
}