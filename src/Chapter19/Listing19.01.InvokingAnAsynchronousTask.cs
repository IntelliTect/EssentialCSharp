namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_01;

#region INCLUDE
using System;
#region HIGHLIGHT
using System.Threading.Tasks;
#endregion HIGHLIGHT

public class Program
{
    public static void Main()
    {
        const int repetitions = 10000;
        // Use Task.Factory.StartNew<string>() for
        // TPL prior to .NET 4.5
        Task task = Task.Run(() =>
            {
                for(int count = 0; count < repetitions; count++)
                {
                    Console.Write('-');
                }
            });
        for(int count = 0; count < repetitions; count++)
        {
            Console.Write('+');
        }

        // Wait until the Task completes
        task.Wait();
    }
}
#endregion INCLUDE
