// Justification: Inline variable declaration not explained yet.
#pragma warning disable IDE0018 // Inline variable declaration
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_35;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        double number; // �ϰ汾C#Ҫ�����������������Ϊout����ʹ��
        string input;

        Console.Write("����һ������: ");
        input = Console.ReadLine();
        #region HIGHLIGHT
        if (double.TryParse(input, out number))
        {
            // ת����ȷ�����ڿ�ʼʹ������
            // ...
        }
        else
        #endregion HIGHLIGHT
        {
            Console.WriteLine(
                "������ı�����һ����Ч�����֡�");
        }
        #endregion INCLUDE
    }
}
