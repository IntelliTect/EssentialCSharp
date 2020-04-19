namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_06
{
    using System;
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
                    if(!antecedentTask.IsFaulted)
                    {
                        throw new Exception("Antecedent Task Should Be Faulted");
                    }
                    Console.WriteLine(
                        "Task State: Faulted");
                },
                TaskContinuationOptions.OnlyOnFaulted);

            Task canceledTask = task.ContinueWith(
                (antecedentTask) =>
                {
                    if (!antecedentTask.IsCanceled)
                    {
                        throw new Exception("Antecedent Task Should Be Canceled");
                    }
                    Console.WriteLine(
                        "Task State: Canceled");
                },
                TaskContinuationOptions.OnlyOnCanceled);

            Task completedTask = task.ContinueWith(
                (antecedentTask) =>
                {
                    if (!antecedentTask.IsCompleted)
                    {
                        throw new Exception("Antecedent Task Should Be Completed");
                    }
                    Console.WriteLine(
                        "Task State: Completed");
                }, TaskContinuationOptions.
                        OnlyOnRanToCompletion);

            completedTask.Wait();

        }

    }
}





