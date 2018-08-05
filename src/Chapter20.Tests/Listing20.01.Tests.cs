using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_01.Tests
{
    [TestClass]
    public class ProgramTests
    {
        public static bool IsIncrementDecrementSynchronized(Action<string[]> action)
        {
            string expected = $"Increment and decrementing \\d* times...{Environment.NewLine}Count = (?<Count>\\d*)";
            bool synchronized = true;

            CancellationTokenSource cancellationtokenSource
                = new CancellationTokenSource();

            // Try multiple times, increasing the increment/decrement iterations, just in case there is a fluke
            ParallelOptions options = new ParallelOptions();
            options.CancellationToken = cancellationtokenSource.Token;
            Program.CancellationToken = cancellationtokenSource.Token;

            try
            {
                Parallel.For(5, 9, options, i =>
                {
                    string output = "";
                    string[] count = { (2 * Math.Pow(10, i)).ToString() };

                    output = IntelliTect.TestTools.Console.ConsoleAssert.Execute("",
                    () =>
                    {
                        action(count);
                    });
                    Console.WriteLine(output);
                    MatchCollection matches = Regex.Matches(output, expected, System.Text.RegularExpressions.RegexOptions.Multiline);
                    if(matches.Count > 0 && matches[0].Success)
                    {
                        string result = matches[0].Groups["Count"].Value;
                        if (result != "0")
                        {
                            synchronized = false;  // No synchronization required for bool
                            cancellationtokenSource.Cancel();
                        }
                    }
                });
            }
            catch(OperationCanceledException){ }
            catch(AggregateException exception)
            {
                foreach (Exception innerException in exception.Flatten().InnerExceptions)
                {
                    if (!(innerException is OperationCanceledException)){}
                    else
                    {
                        System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(
                            exception.InnerException).Throw();
                    }
                }
            }
            return synchronized;
        }

        [TestMethod]
        public void UnsynchronizedIncrementAndDecrement()
        {
            Assert.IsFalse(
                IsIncrementDecrementSynchronized(Program.Main));
        }
    }
}
