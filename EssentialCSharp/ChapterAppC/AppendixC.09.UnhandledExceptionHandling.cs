namespace AddisonWesley.Michaelis.EssentialCSharp.AppendixC.ListingC_09
{
    using System;
    using System.ComponentModel;
    using System.Text;
    using System.Threading;

    public class PiCalculator
    {
        public static BackgroundWorker calculationWorker =
            new BackgroundWorker();
        public static AutoResetEvent resetEvent =
            new AutoResetEvent(false);

        public static void Main()
        {
            int digitCount;

            Console.Write(
                "Enter the number of digits to calculate:");
            if(int.TryParse(Console.ReadLine(), out digitCount))
            {
                Console.WriteLine("ENTER to cancel");
                // C# 2.0 Syntax for registering delegates
                calculationWorker.DoWork += CalculatePi;
                // Register the ProgressChanged callback
                calculationWorker.ProgressChanged +=
                    UpdateDisplayWithMoreDigits;
                calculationWorker.WorkerReportsProgress = true;
                // Register a callback for when the 
                // calculation completes
                calculationWorker.RunWorkerCompleted +=
                    new RunWorkerCompletedEventHandler(Complete);
                calculationWorker.WorkerSupportsCancellation = true;

                // Begin calculating pi for up to digitCount digits
                calculationWorker.RunWorkerAsync(digitCount);

                Console.ReadLine();
                // If cancel is called after the calculation
                // has completed it doesn't matter.
                calculationWorker.CancelAsync();
                // Wait for Complete() to run.
                resetEvent.WaitOne();
            }
            else
            {
                Console.WriteLine(
                    "The value entered is an invalid integer.");
            }
        }

        private static void CalculatePi(
            object sender, DoWorkEventArgs eventArgs)
        {
            int digits = (int)eventArgs.Argument;

            StringBuilder pi = new StringBuilder("3.", digits + 2);
            calculationWorker.ReportProgress(0, pi.ToString());

            // Calculate rest of pi, if required
            if(digits > 0)
            {
                for(int i = 0; i < digits; i += 9)
                {

                    // Calculate next i decimal places
                    int nextDigit = Shared.PiCalculator.InternalPiDigitCalculator.ComputeSection(
                        i + 1);
                    int digitCount = Math.Min(digits - i, 9);
                    string ds = string.Format("{0:D9}", nextDigit);
                    pi.Append(ds.Substring(0, digitCount));

                    // Show current progress
                    calculationWorker.ReportProgress(
                        0, ds.Substring(0, digitCount));

                    // Check for cancellation
                    if(calculationWorker.CancellationPending)
                    {
                        // Need to set Cancel if you need to 
                        // distinguish how a worker thread completed
                        // i.e., by checking 
                        // RunWorkerCompletedEventArgs.Cancelled
                        eventArgs.Cancel = true;
                        break;
                    }
                }
            }

            eventArgs.Result = pi.ToString();
        }

        private static void UpdateDisplayWithMoreDigits(
            object sender, ProgressChangedEventArgs eventArgs)
        {
            string digits = (string)eventArgs.UserState;

            Console.Write(digits);
        }

        static void Complete(
            object sender, RunWorkerCompletedEventArgs eventArgs)
        {
            Console.WriteLine();
            if(eventArgs.Cancelled)
            {
                Console.WriteLine("Cancelled");
            }
            else if(eventArgs.Error != null)
            {
                //IMPORTANT: check error to retrieve any exceptions.
                Console.WriteLine("ERROR: {0}", eventArgs.Error.Message);
            }
            else
            {
                Console.WriteLine("Finished (press enter to continue)");
            }
            resetEvent.Set();
        }
    }
}