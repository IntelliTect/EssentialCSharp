
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_20.Tests;

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
