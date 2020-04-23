namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_13
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            DisplayStatus("Before");
            Task taskA =
                Task.Run(() =>
                     DisplayStatus("Starting..."))
                .ContinueWith(antecedent =>
                     DisplayStatus("Continuing A..."));
            Task taskB = taskA.ContinueWith(antecedent =>
          DisplayStatus("Continuing B..."));
            Task taskC = taskA.ContinueWith(antecedent =>
                DisplayStatus("Continuing C..."));
            Task.WaitAll(taskB, taskC);
            DisplayStatus("Finished!");
        }

        private static void DisplayStatus(string message)
        {
            string text = 
                    $@"{ Thread.CurrentThread.ManagedThreadId 
                        }: { message }";


            Console.WriteLine(text);
        }
    }
}





