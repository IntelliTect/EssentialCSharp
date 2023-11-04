namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_03;

#region INCLUDE
using System;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
    #region HIGHLIGHT
    static readonly object _Sync = new();
    #endregion HIGHLIGHT
    static int _Total = int.MaxValue;
    static int _Count = 0;

    public static int Main(string[] args)
    {
        if (args?.Length > 0) { _ = int.TryParse(args[0], out _Total); }
        Console.WriteLine("Increment and decrementing " +
            $"{_Total} times...");

        // Use Task.Factory.StartNew for .NET 4.0
        Task task = Task.Run(() => Decrement());

        // Increment
        for(int i = 0; i < _Total; i++)
        {
            #region HIGHLIGHT
            bool lockTaken = false;
            try
            {
                Monitor.Enter(_Sync, ref lockTaken);
                _Count++;
            }
            finally
            {
                if(lockTaken)
                {
                    Monitor.Exit(_Sync);
                }
            }
            #endregion HIGHLIGHT
        }

        task.Wait();
        Console.WriteLine($"Count = {_Count}");
        return _Count;
    }

    public static void Decrement()
    {
        for(int i = 0; i < _Total; i++)
        {
            #region HIGHLIGHT
            bool lockTaken = false;
            try
            {
                Monitor.Enter(_Sync, ref lockTaken);
                _Count--;
            }
            finally
            {
                if(lockTaken)
                {
                    Monitor.Exit(_Sync);
                }
            }
            #endregion HIGHLIGHT
        }
    }
}
#endregion INCLUDE
