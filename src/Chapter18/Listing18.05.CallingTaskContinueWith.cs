namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_05
{
    using System;
    using System.Threading.Tasks;

    public class Program
    {
        public static void ChapterMain()
        {
            Console.WriteLine("Before");
            // Use Task.Factory.StartNew<string>() for
            // TPL prior to .NET 4.5
            Task taskA =
                Task.Run(() =>
                     Console.WriteLine("Starting..."))
                .ContinueWith(antecedent =>
                     Console.WriteLine("Continuing A..."));
            Task taskB = taskA.ContinueWith(antecedent =>
                Console.WriteLine("Continuing B..."));
            Task taskC = taskA.ContinueWith(antecedent =>
                Console.WriteLine("Continuing C..."));
            Task.WaitAll(taskB, taskC);
            Console.WriteLine("Finished!");
        }
    }
}