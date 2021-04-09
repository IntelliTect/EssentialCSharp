using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_01.Tests
{
    [TestClass]
    public class UppercaseTests
    {
        [TestMethod]
        public void Main_GivenArgs_NumberDoubles()
        {
            string[] args = { "arg0", "arg1" };
            string expected =
                $"\'number\' doubled is { args[0].Length * 2 }.";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, ()=>Program.Main(args));
        }

        [TestMethod]
        public void Main_GivenValidString_MakeUppercase()
        {
            string[] args = { };
            const string expected =
                "\'number\' requires a value and cannot be null";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, () => Program.Main(args));
        }
    }
}