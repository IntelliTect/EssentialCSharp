using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Table04_04.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void EqualityCheckForNull()
        {
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                "Uri is null", ()=>Program.EqualityCheckForNull(null));

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                "Uri is: NotNull", () => Program.EqualityCheckForNull("NotNull"));
        }

        [TestMethod]
        public void PatternMatchingCheckForNull()
        {
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                "Uri is null", () => Program.PatternMatchingCheckForNull(null));

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                "Uri is: NotNull", () => Program.PatternMatchingCheckForNull("NotNull"));
        }

        [TestMethod]
        public void PropertPatternMatchingCheckForNull()
        {
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                "Uri is null", () => Program.PropertyPatternMatchingCheckForNull(null));

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                "Uri is: NotNull", () => Program.PropertyPatternMatchingCheckForNull("NotNull"));
        }
    }
}