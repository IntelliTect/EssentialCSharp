using AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_14;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_13.Tests
{
    [TestClass]
    public class PairTests
    {
        [TestMethod]
        public void CreatePair_GivenNullableStrings_Success()
        {
            Pair<string?, string?> pair = new Pair<string?, string?>(null, null);
            Assert.AreEqual<(string?, string?)>(
                (null, null), (pair.First, pair.Second));
        }

        [TestMethod]
        public void CreatePair_GivenNullableInts_Success()
        {
            Pair<int?, int?> pair = new Pair<int?, int?>(null, null);
            Assert.AreEqual<(int?, int?)>(
                (null, null), (pair.First, pair.Second));
        }

        public void CreatePair_GivenNonNullableStrings_Success()
        {
            Pair<string, string> pair = new Pair<string, string>("Inigo", "Montoya");
            Assert.AreEqual<(string, string)>(
                ("Inigo", "Montoya"), (pair.First, pair.Second));
        }

        [TestMethod]
        public void CreatePair_GivenNonNullableInts_Success()
        {
            Pair<int?, int?> pair = new Pair<int?, int?>(42, 42);
            Assert.AreEqual<(int?, int?)>(
                (42, 42), (pair.First, pair.Second));
        }
    }
}
