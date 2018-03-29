using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_01.Tests
{
    [TestClass]
    public class ProgramTests
    {

        [TestMethod]
        public void NeedsAName()
        {
            TextNumberParser.Parse("1");
            throw new System.NotImplementedException();
        }
    }
}