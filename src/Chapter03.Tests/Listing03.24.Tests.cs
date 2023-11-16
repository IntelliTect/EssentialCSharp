namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_24.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_ThrowsIndexOutOfRangeException()
    {
        Assert.ThrowsException<IndexOutOfRangeException>(Program.Main);
    }
}
