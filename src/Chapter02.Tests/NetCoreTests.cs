
namespace AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;

[TestClass]
public class NetCoreTests
{
    [TestMethod]
    public void GetAllValidNETPreprocessorSymbols_ContainsCorrectSymbols()
    {
        List<string> preprocessorSymbols = NetCore.GetAllValidNETPreprocessorSymbols(8, 0).ToList();
        CollectionAssert.Contains(preprocessorSymbols, "NET8_0");
        CollectionAssert.Contains(preprocessorSymbols, "NET8_0_OR_GREATER");
        CollectionAssert.Contains(preprocessorSymbols, "NET7_0_OR_GREATER");
        CollectionAssert.Contains(preprocessorSymbols, "NET6_0_OR_GREATER");
        CollectionAssert.Contains(preprocessorSymbols, "NET5_0_OR_GREATER");
        CollectionAssert.Contains(preprocessorSymbols, "NETCOREAPP3_1_OR_GREATER");
        CollectionAssert.Contains(preprocessorSymbols, "NETCOREAPP3_0_OR_GREATER");

        Assert.AreEqual(preprocessorSymbols.Count, preprocessorSymbols.Distinct().Count());
    }
}
