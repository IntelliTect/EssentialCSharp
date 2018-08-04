using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_05.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main_GiveNone_GetZero()
        {
            int expected = 0;
            int value = Program.Main(new string[0]);

            Assert.AreEqual(expected, value);
        }
    }
}