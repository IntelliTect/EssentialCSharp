namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_18;

#region INCLUDE
public class IncrementExample
{
    public static void Main()
    {
        int x = 123;
        // ��ʾ��123, 124, 125
        Console.WriteLine($"{x++}, {x++}, {x}");
        // x���ڵ�ֵ��125
        // ��ʾ��126, 127, 127
        Console.WriteLine($"{++x}, {++x}, {x}");
        // x���ڵ�ֵ��127
    }
}
#endregion INCLUDE
