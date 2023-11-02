
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_25.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        string expected =
$@"Enter the radius of the circle: <<3
>>The area of the circle is: {28.27}";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, CircleAreaCalculator.Main);
    }
}
