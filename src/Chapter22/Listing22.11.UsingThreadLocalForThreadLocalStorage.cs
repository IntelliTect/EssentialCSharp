namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_11;

#region INCLUDE
using System;
using System.Threading;

public class Program
{
    #region HIGHLIGHT
    static ThreadLocal<double> _Count = new(() => 0.01134);
    #endregion HIGHLIGHT
    public static double Count
    {
        get { return _Count.Value; }
        set { _Count.Value = value; }
    }

    public static void Main()
    {
        Thread thread = new(Decrement);
        thread.Start();

        // Increment
        for(double i = 0; i < short.MaxValue; i++)
        {
            Count++;
        }
        thread.Join();
        Console.WriteLine("Main Count = {0}", Count);
    }

    public static void Decrement()
    {
        Count = -Count;
        for(double i = 0; i < short.MaxValue; i++)
        {
            Count--;
        }
        Console.WriteLine(
            "Decrement Count = {0}", Count);
    }
}
#endregion INCLUDE
