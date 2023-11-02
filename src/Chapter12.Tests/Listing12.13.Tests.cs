using AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_14;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_13.Tests;

[TestClass]
public class PairTests
{
    [TestMethod]
    public void CreatePair_GivenNullableStrings_Success()
    {
        Pair<string?, string?> pair = new(null, null);
        Assert.AreEqual<(string?, string?)>(
            (null, null), (pair.First, pair.Second));
    }

    [TestMethod]
    public void CreatePair_GivenNullableInts_Success()
    {
        Pair<int?, int?> pair = new(null, null);
        Assert.AreEqual<(int?, int?)>(
            (null, null), (pair.First, pair.Second));
    }

    [TestMethod]
    public void CreatePair_GivenNonNullableStrings_Success()
    {
        Pair<string, string> pair = new("Inigo", "Montoya");
        Assert.AreEqual<(string, string)>(
            ("Inigo", "Montoya"), (pair.First, pair.Second));
    }

    [TestMethod]
    public void CreatePair_GivenNonNullableInts_Success()
    {
        Pair<int?, int?> pair = new(42, 42);
        Assert.AreEqual<(int?, int?)>(
            (42, 42), (pair.First, pair.Second));
    }
}
