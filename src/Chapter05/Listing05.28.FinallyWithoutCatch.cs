namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_28;

#region INCLUDE
using System;

public class ExceptionHandling
{
    public static int Main()
    {
        string? firstName;
        string ageText;
        int age;
        int result = 0;

        Console.Write("�������������: ");
        firstName = Console.ReadLine();

        Console.Write("�������������: ");
        // ���費Ϊ��        // 
        ageText = Console.ReadLine()!;

        try
        {
            age = int.Parse(ageText);
            Console.WriteLine(
                $"��ã�{firstName}������{age * 12}���´��ˡ�"); 
        }
        finally
        {
            Console.WriteLine($"�ټ���{firstName}��");
        }

        return result;
    }
}
#endregion INCLUDE
