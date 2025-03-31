
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_33.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_NoArgs_ExpectErrors()
    {
        string expected = "Value cannot be null. (Parameter \'httpsUrl\')";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            try
            {
                Program.Main();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        });
    }
}
