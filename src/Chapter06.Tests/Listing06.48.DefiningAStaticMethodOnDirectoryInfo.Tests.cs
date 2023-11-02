
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_48.Tests;

[TestClass]
public class DirectoryTests
{
    [TestMethod]
    public void MainTest()
    {
        string source = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        string target = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        try
        {
            Directory.CreateDirectory(source);
            Directory.CreateDirectory(target);
            IntelliTect.TestTools.Console.ConsoleAssert.Execute(null, () => Program.Main(source, target));
        }
        finally
        {
            if(Directory.Exists(source)) { Directory.Delete(source, recursive: true); }
            if(Directory.Exists(target)) { Directory.Delete(target, recursive: true); }
        }
    }
}
