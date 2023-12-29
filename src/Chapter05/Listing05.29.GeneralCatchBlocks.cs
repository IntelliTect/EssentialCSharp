namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_29;
#pragma warning disable CS0168 // Variable is declared but never used

#region INCLUDE
// ��һ��catch�Ӿ��Ѳ��������쳣
#pragma warning disable CS1058
#region EXCLUDE
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
        // ���費Ϊ��
        ageText = Console.ReadLine()!;

        #endregion EXCLUDE
        try
        {
            age = int.Parse(ageText);
            Console.WriteLine(
                $"��ã�{firstName}������{age * 12}���´��ˡ�");
        }
        catch(FormatException exception)
        {
            Console.WriteLine(
                $"�����������'{ageText}'����һ����Ч��������"); 
            result = 1;
        }
        catch(Exception exception)
        {
            Console.WriteLine(
                $"��Ԥ�ڵĴ���: {exception.Message}");
            result = 1;
        }
        catch
        {
            Console.WriteLine("��Ԥ�ڵĴ���!");
            result = 1;
        }
        finally
        {
            Console.WriteLine($"�ټ���{firstName}��");
        }
        #endregion INCLUDE
        return result;
    }
}
