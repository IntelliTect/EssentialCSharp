namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_03;

public class Uppercase
{
    public static void Main()
    {
        #region INCLUDE
        Console.Write("�����ı�: ");
        var text = Console.ReadLine();

        // ����ȫ��д��һ�����ַ���
        var uppercase = text.ToUpper();
        Console.WriteLine(uppercase);
        #endregion INCLUDE
    }
}
