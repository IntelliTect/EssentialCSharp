
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_21.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_WritePath()
    {
        string view = Path.Combine(Directory.GetCurrentDirectory(), "bin", "config", "index.html");
        view += Environment.NewLine;
        view += Path.Combine(Environment.SystemDirectory, "Temp", "index.html");
        view += Environment.NewLine;
        view += Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Documents",
                "Web", "index.html");

//            string view =
//Directory.GetCurrentDirectory() + @"\bin\config\index.html
//" + Directory.GetParent(Directory.GetCurrentDirectory()).FullName + @"\Temp\index.html
//C:\Data\HomeDir\index.html";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(view,
            Program.Main);
    }
}
