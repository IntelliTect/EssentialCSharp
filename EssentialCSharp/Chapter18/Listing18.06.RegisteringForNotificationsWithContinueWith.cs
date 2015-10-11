﻿namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_06
{
    using System;
    using System.Diagnostics;
    using System.Threading.Tasks;
    using AddisonWesley.Michaelis.EssentialCSharp.Shared;

    public class Program
    {
        public static void Main()
        {
            // Use Task.Factory.StartNew<string>() for
            // TPL prior to .NET 4.5
            Task<string> task =
                Task.Run<string>(
                    () => PiCalculator.Calculate(10));
            Task faultedTask = task.ContinueWith(
                (antecedentTask) =>
                {
                    Trace.Assert(antecedentTask.IsFaulted);
                    Console.WriteLine(
                        "Task State: Faulted");
                },
                TaskContinuationOptions.OnlyOnFaulted);

            Task canceledTask = task.ContinueWith(
                (antecedentTask) =>
                {
                    Trace.Assert(antecedentTask.IsCanceled);
                    Console.WriteLine(
                        "Task State: Canceled");
                },
                TaskContinuationOptions.OnlyOnCanceled);

            Task completedTask = task.ContinueWith(
                (antecedentTask) =>
                {
                    Trace.Assert(antecedentTask.IsCompleted);
                    Console.WriteLine(
                        "Task State: Completed");
                }, TaskContinuationOptions.
                        OnlyOnRanToCompletion);

            completedTask.Wait();

        }

    }
}





