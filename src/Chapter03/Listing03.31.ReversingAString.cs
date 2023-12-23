namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_31;

public class Palindrome
{
    public static void Main()
    {
        #region INCLUDE
        string reverse, palindrome;
        char[] temp;

        Console.Write("����һ�����: ");
        palindrome = Console.ReadLine();

        // ɾ���ո񣬲�ת����Сд
        reverse = palindrome.Replace(" ", "");
        reverse = reverse.ToLower();

        #region HIGHLIGHT
        // ת�����ַ�����
        temp = reverse.ToCharArray();
        #endregion HIGHLIGHT

        #region HIGHLIGHT
        // ��ת����
        Array.Reverse(temp);
        #endregion HIGHLIGHT

        // ������ת�����ַ����������
        // ��ת����ַ����Ƿ����
        if (reverse == new string(temp))
        {
            Console.WriteLine(
                $"\"{palindrome}\"�ǻ��ġ�");
        }
        else
        {
            Console.WriteLine(
                $"\"{palindrome}\"���ǻ��ġ�");
        }
        #endregion INCLUDE
    }
}
