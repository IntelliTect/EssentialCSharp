namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_02;

#region INCLUDE
using System;
using System.Threading.Tasks;
using AddisonWesley.Michaelis.EssentialCSharp.Shared; // EXCLUDE

public class Program
{
    public static void Main()
    {
        // Use Task.Factory.StartNew<string>() for
        // TPL prior to .NET 4.5
        #region HIGHLIGHT
        Task<string> task =
            Task.Run<string>(
        #endregion HIGHLIGHT
                () => PiCalculator.Calculate(100));

        foreach (
            char busySymbol in Utility.BusySymbols())
        {
            if (task.IsCompleted)
            {
                Console.Write('\b');
                break;
            }
            Console.Write(busySymbol);
        }

        Console.WriteLine();

        #region HIGHLIGHT
        Console.WriteLine(task.Result);
        #endregion HIGHLIGHT
        if (!task.IsCompleted)
        {
            throw new Exception("Task Should Be Completed");
        }
    }
}
#region EXCLUDE
/*
#endregion EXCLUDE
public class PiCalculator
{
    public static string Calculate(int digits = 100)
    {
        //...
    }
}
public class Utility
{
    public static IEnumerable<char> BusySymbols()
    {
        string busySymbols = @"-\|/-\|/";
        int next = 0;
        while (true)
        {
            yield return busySymbols[next];
            next = (next + 1) % busySymbols.Length;
            yield return '\b';
        }
    }
}
#region EXCLUDE
*/
#endregion EXCLUDE
#endregion INCLUDE
