namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_07.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public async Task MainTest()
        {
            await IntelliTect.TestTools.Console.ConsoleAssert.ExecuteAsync("", async () => await AsyncEncryptionCollection.Main());
        }
    }
}