using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using AddisonWesley.Michaelis.EssentialCSharp.Shared;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22
{
    partial class PiCalculation
    {
        public void CalculateAsync(
            int digits)
        {
            CalculateAsync(digits, null);
        }
        public void CalculateAsync(
            int digits, object? userState)
        {
            CalculateAsync(
                digits, default, userState);
        }
        public void CalculateAsync<TState>(
            int digits,
            CancellationToken cancelToken,
            TState userState)
        {
            Task<string>.Factory.StartNew(
                () => PiCalculator.Calculate(digits), cancelToken)
                .ContinueWith<string>(
                    continueTask =>
                    {
                        CalculateCompleted?.Invoke(typeof(PiCalculator),
                            new CalculateCompletedEventArgs(
                                continueTask.Result,
                                continueTask.Exception,
                                cancelToken.IsCancellationRequested,
                                userState));
                        return continueTask.Result;
                    });
        }
        public event
            EventHandler<CalculateCompletedEventArgs>
                CalculateCompleted = delegate { };

        public class CalculateCompletedEventArgs
            : AsyncCompletedEventArgs
        {
            public CalculateCompletedEventArgs(
                string value,
                Exception? error,
                bool cancelled,
                object? userState)
                : base(
                    error, cancelled, userState)
            {
                Result = value;
            }
            public string Result { get; private set; }
        }
    }
}
