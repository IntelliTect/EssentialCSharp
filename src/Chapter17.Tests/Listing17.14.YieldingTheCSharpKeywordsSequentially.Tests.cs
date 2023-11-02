
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_14.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"object
byte
uint
ulong
float
char
bool
ushort
decimal
int
sbyte
short
long
void
double
string";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
