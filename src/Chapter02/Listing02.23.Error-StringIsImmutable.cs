namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_23;

public class Uppercase
{
    public static void Main()
    {
        #region INCLUDE
        Console.Write("�����ı�: ");
        string text = Console.ReadLine();

        #region HIGHLIGHT
        // UNEXPECTED: text��û��ת��Ϊȫ��д
        text.ToUpper();
        #endregion HIGHLIGHT

        Console.WriteLine(text);
        #endregion INCLUDE
    }
}
