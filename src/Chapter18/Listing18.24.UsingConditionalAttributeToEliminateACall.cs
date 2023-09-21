#region INCLUDE
#define CONDITION_A
#region EXCLUDE
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_24;

#endregion EXCLUDE
using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Begin...");
        MethodA();
        MethodB();
        Console.WriteLine("End...");
    }

    [Conditional("CONDITION_A")]
    public static void MethodA()
    {
        Console.WriteLine("MethodA() executing...");
    }

    [Conditional("CONDITION_B")]
    public static void MethodB()
    {
        Console.WriteLine("MethodB() executing...");
    }
}
#endregion INCLUDE
