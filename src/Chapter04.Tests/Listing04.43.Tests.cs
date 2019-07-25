using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_43.Tests
{
    [TestClass]
    public class FibonacciCalculatorTests
    {
        [TestMethod]
        public void Main_Enter0_Write1()
        {
            const string expected =
@"Enter a positive integer:<<0
>>The Fibonacci number following this is 1";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, FibonacciCalculator.Main);
        }
        
        [TestMethod]
        public void Main_Enter1_Write1() // returns next number in sequence GREATER than input
        {
            const string expected =
@"Enter a positive integer:<<1
>>The Fibonacci number following this is 2";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, FibonacciCalculator.Main);
        }
        
        [TestMethod]
        public void Main_Enter21_Write34()
        {
            const string expected =
@"Enter a positive integer:<<21
>>The Fibonacci number following this is 34";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, FibonacciCalculator.Main);
        }
    }
}