using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_01.Tests
{
  [TestClass]
  public class LiteralValueTests
  {
    [TestMethod]
    public void Main_WriteNumbers()
    {
      string expected = 42.ToString() + Environment.NewLine + 1.618034.ToString();

      IntelliTect.TestTools.Console.ConsoleAssert.Expect(
          expected, Program.Main);
    }
  }
}