using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_01.Tests
{
  [TestClass]
  public class LiteralValueTests
  {
    [TestMethod]
    public void Main_WriteNumbers()
    {
      const string expected =
@"42
1.618034";

      IntelliTect.TestTools.Console.ConsoleAssert.Expect(
          expected, Program.Main);
    }
  }
}