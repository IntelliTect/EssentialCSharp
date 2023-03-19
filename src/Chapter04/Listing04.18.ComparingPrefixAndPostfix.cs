namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_18;

#region INCLUDE
public class IncrementExample
{
    public static void Main()
    {
        int x = 123;
        // Displays 123, 124, 125
        Console.WriteLine($"{x++}, {x++}, {x}");
        // x now contains the value 125
        // Displays 126, 127, 127
        Console.WriteLine($"{++x}, {++x}, {x}");
        // x now contains the value 127
    }
}
#endregion INCLUDE
