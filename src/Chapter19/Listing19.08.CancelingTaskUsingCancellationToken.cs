namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_08;

#region INCLUDE
using System;
using System.Threading;
using System.Threading.Tasks;
using AddisonWesley.Michaelis.EssentialCSharp.Shared;

public class Program
{
    public static void Main()
    {
        string stars =
            "*".PadRight(Console.WindowWidth - 1, '*');
        Console.WriteLine("Push ENTER to exit.");

        #region HIGHLIGHT
        CancellationTokenSource cancellationTokenSource = new();
        // Use Task.Factory.StartNew<string>() for
        // TPL prior to .NET 4.5
        Task task = Task.Run(
            () =>
                WritePi(cancellationTokenSource.Token),
                    cancellationTokenSource.Token);
        #endregion HIGHLIGHT

        // Wait for the user's input
        Console.ReadLine();

        #region HIGHLIGHT
        cancellationTokenSource.Cancel();
        #endregion HIGHLIGHT
        Console.WriteLine(stars);
        #region HIGHLIGHT
        task.Wait();
        #endregion HIGHLIGHT
        Console.WriteLine();
    }

    private static void WritePi(
    #region HIGHLIGHT
        CancellationToken cancellationToken)
    #endregion HIGHLIGHT
    {
        const int batchSize = 1;
        string piSection = string.Empty;
        int i = 0;

        #region HIGHLIGHT
        while (!cancellationToken.IsCancellationRequested
        #endregion HIGHLIGHT
            || i == int.MaxValue)
        {
            piSection = PiCalculator.Calculate(
                batchSize, (i++) * batchSize);
            Console.Write(piSection);
        }
    }
}
#endregion INCLUDE
