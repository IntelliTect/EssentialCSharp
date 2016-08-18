

namespace AddisonWesley.Michaelis.EssentialCSharp.Shared.Listing18_03
{

    using System;
    using System.Threading.Tasks;
    using System.Diagnostics; 

    public class Program
    {
        public static void ChapterMain()
        {
            Task<string> task = Task.Factory.StartNew<string>(
                () => PiCalculator.Calculate(10));

            Task faultedTask = task.ContinueWith(
                (antecedentTask) =>
                {
                    Console.WriteLine("Task State: Faulted");
                },
                TaskContinuationOptions.OnlyOnFaulted);
            Task canceledTask = task.ContinueWith(
                (antecedentTask) =>
                {
                    Console.WriteLine("Task State: Canceled");
                },
                TaskContinuationOptions.OnlyOnCanceled);
            Task completedTask = task.ContinueWith(
                (antecedentTask) =>
                {
                    Console.WriteLine("Task State: Completed");
                },
                TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();
        }
    }
}
