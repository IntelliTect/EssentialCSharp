namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_05
{
    using System;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
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
            Task taskC = taskB.ContinueWith(antecedent =>
                Console.WriteLine("Continuing C..."));
            Task.WaitAll(taskC);
            Console.WriteLine("Finished!");
        }
    }
}