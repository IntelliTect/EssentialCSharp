
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_09.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_GiveNone_GetZero()
    {
        int expected = 0;
        int value = Program.Main(Array.Empty<string>());

        Assert.AreEqual(expected, value);
    }
}
