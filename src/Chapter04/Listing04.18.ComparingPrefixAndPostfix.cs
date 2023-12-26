namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_18;

#region INCLUDE
public class IncrementExample
{
    public static void Main()
    {
        int x = 123;
        // 显示：123, 124, 125
        Console.WriteLine($"{x++}, {x++}, {x}");
        // x现在的值是125
        // 显示：126, 127, 127
        Console.WriteLine($"{++x}, {++x}, {x}");
        // x现在的值是127
    }
}
#endregion INCLUDE
