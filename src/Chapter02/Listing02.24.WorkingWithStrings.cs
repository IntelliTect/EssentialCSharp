namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_24;
#region INCLUDE
public class Uppercase
{
    public static void Main()
    {
        string text, uppercase;

        Console.Write("�����ı�: ");
        text = Console.ReadLine();

        // ����ȫ��д��һ�����ַ���
        #region HIGHLIGHT
        uppercase = text.ToUpper();
        #endregion HIGHLIGHT

        Console.WriteLine(uppercase);
    }
}
#endregion INCLUDE