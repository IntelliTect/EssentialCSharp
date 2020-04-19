using System;
using System.Text;

namespace AddisonWesley.Michaelis.EssentialCSharp.Shared
{
    public static partial class PiCalculator
    {
        const int Digits = 100;
        #region Helper
        public static string Pi()
        {
            return Calculate();
        }

        public static string Calculate(int digits = Digits)
        {
            return Calculate(digits, 0);
        }

        public static string Calculate(int digits, int startingAt)
        {
            DoWorkEventArgs eventArgs = new DoWorkEventArgs(digits);

            CalculatePi(typeof(PiCalculator), eventArgs, startingAt);
            return (string)eventArgs.Result!;
        }

        private static void CalculatePi(
            object sender, DoWorkEventArgs eventArgs)
        {
            CalculatePi(sender, eventArgs, 0);
        }

        private static void CalculatePi(
            object sender, DoWorkEventArgs eventArgs, int startingAt)
        {
            int digits = (int)eventArgs.Argument;

            StringBuilder pi;
            if(startingAt == 0)
            {
                pi = new StringBuilder("3.", digits + 2);
            }
            else
            {
                pi = new StringBuilder();
            }
#if BackgroundWorkerThread
            calculationWorker.ReportProgress(0, pi.ToString());
#endif

            // Calculate rest of pi, if required
            if(digits > 0)
            {
                for(int i = 0; i < digits; i += 9)
                {

                    // Calculate next i decimal places
                    int nextDigit = InternalPiDigitCalculator.ComputeSection(
                        startingAt + i + 1);
                    int digitCount = Math.Min(digits - i, 9);
                    string ds = string.Format("{0:D9}", nextDigit);
                    pi.Append(ds.Substring(0, digitCount));

                    // Show current progress
#if BackgroundWorkerThread
                    calculationWorker.ReportProgress(
                        0, ds.Substring(0, digitCount));
#endif

#if BackgroundWorkerThread
                    // Check for cancellation
                    if (calculationWorker.CancellationPending)
                    {
                        // Need to set Cancel if you need to  
                        // distinguish how a worker thread completed
                        // ie by checking 
                        // RunWorkerCompletedEventArgs.Cancelled
                        eventArgs.Cancel = true;
                        break;
                    }
#endif
                }
            }

            eventArgs.Result = pi.ToString();
        }
        #endregion
    }
}
