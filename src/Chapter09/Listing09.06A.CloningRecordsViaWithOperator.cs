
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_06A;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_01;
#region INCLUDE
using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        Angle angle = new(90, 0, 0);

         // The with operator is the equivalent of
        // Angle copy = new(degrees, minutes, seconds);
        Angle copy = angle with { };
        Trace.Assert(angle == copy);

        // The with operator has object initializer type
        // syntax for instantiating a modified copy.
        Angle modifiedCopy = angle with { Degrees = 180 };
        Trace.Assert(angle != modifiedCopy);
    }
}
#endregion INCLUDE
