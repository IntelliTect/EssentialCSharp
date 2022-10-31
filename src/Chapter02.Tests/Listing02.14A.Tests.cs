using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_14A.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Main_WriteTriangle()
        {
            const string expected = @"Begin
           ____
          /   /\
         /   /  \
        /   /   /\
       /   /   /  \
      /   /   /\   \
     /   /   /  \   \
    /   /   /\   \   \
   /   /   /  \   \   \
  /___/___/____\   \   \
 /     {mobius} \   \   \
/________________\   \   \
\                 \   \  /
 \_________________\___\/
End";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Triangle.Main);
        }
    }
}