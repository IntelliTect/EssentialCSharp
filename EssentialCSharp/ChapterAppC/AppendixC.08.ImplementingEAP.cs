
namespace AddisonWesley.Michaelis.EssentialCSharp.AppendixC.ListingC_08
{
    using System;
    using System.ComponentModel;
    using System.Threading;
    using System.Threading.Tasks;
    using AddisonWesley.Michaelis.EssentialCSharp.Shared;

    public class Program
    {
        public static void Main()
        {
            ManualResetEventSlim resetEvent =
                new ManualResetEventSlim();
            PiCalculation piCalculation = new PiCalculation();
            piCalculation.CalculateCompleted +=
                (object sender,
                    PiCalculation.CalculateCompletedEventArgs eventArgs) =>
                {
                    Console.WriteLine(
                        Environment.NewLine + eventArgs.Result);
                    resetEvent.Set();
                };
            piCalculation.CalculateAsync(500, null);

            while (!resetEvent.Wait(100))
            {
                Console.Write(".");
            }
        }
    }

    partial class PiCalculation
    {
        public void CalculateAsync(
            int digits)
        {
            CalculateAsync(digits, null);
        }
        public void CalculateAsync(
            int digits, object userState)
        {
            CalculateAsync(
                digits, default(CancellationToken), userState);
        }
        public void CalculateAsync<TState>(
            int digits,
            CancellationToken cancelToken
              = default(CancellationToken),
            TState userState
              = default(TState))
        {
            SynchronizationContext.
                SetSynchronizationContext(
                   AsyncOperationManager.
                       SynchronizationContext);

            // Ensure the continuation runs on the current
            // thread, and that therefore the event will 
            // be raised on the same thread that called
            // this method in the first place.
            TaskScheduler scheduler =
                TaskScheduler.
                    FromCurrentSynchronizationContext();
            Task.Run(
                () =>
                {
                    return PiCalculator.Calculate(digits);
                }, cancelToken)
                .ContinueWith(
                    continueTask =>
                    {
                        Exception exception =
                            continueTask.Exception == null ?
                            continueTask.Exception :
                            continueTask.Exception.
                                 InnerException;
                        CalculateCompleted(
                            typeof(PiCalculator),
                            new CalculateCompletedEventArgs(
                                continueTask.Result,
                                exception,
                                cancelToken.IsCancellationRequested,
                                userState));
                    }, scheduler);
        }

        public event
            EventHandler<CalculateCompletedEventArgs>
                CalculateCompleted = delegate { };


        public class CalculateCompletedEventArgs
            : AsyncCompletedEventArgs
        {
            public CalculateCompletedEventArgs(
                string value,
                Exception error,
                bool cancelled,
                object userState)
                : base(
                    error, cancelled, userState)
            {
                Result = value;
            }
            public string Result { get; private set; }
        }
    }
}







