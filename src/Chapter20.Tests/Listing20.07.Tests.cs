namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_07.Tests;

[TestClass]
public class AsyncEncryptionCollectionTests
{
    [TestMethod]
    public async Task MainDoesNotThrow()
    {
        await IntelliTect.TestTools.Console.ConsoleAssert.ExecuteAsync("", async () => await AsyncEncryptionCollection.Main());
    }
}