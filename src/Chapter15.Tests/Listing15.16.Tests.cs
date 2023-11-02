
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_16.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"1. Patents prior to the 1900s are:
	Phonograph (1877)
	Kinetoscope (1888)
	Electrical Telegraph (1837)
	Steam Locomotive (1815)

2. A second listing of patents prior to the 1900s:
	Phonograph (1877)
	Kinetoscope (1888)
	Electrical Telegraph (1837)
	Steam Locomotive (1815)
   There are 4 patents prior to 1900.

3. A third listing of patents prior to the 1900s:
	Phonograph (1877)
	Kinetoscope (1888)
	Electrical Telegraph (1837)
	Steam Locomotive (1815)
   There are 4 patents prior to 1900.";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}