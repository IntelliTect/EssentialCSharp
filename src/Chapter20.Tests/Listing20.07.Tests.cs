using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_07.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [Ignore]
        [TestMethod]
        public async Task MainTest()
        {
            await IntelliTect.TestTools.Console.ConsoleAssert.ExpectAsync("<filename>", async () => await AsyncEncryptionCollection.Main());
        }
    }
}