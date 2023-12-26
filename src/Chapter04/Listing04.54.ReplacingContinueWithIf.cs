namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_54;

public class EmailDomain
{
    public static void Main()
    {
        string email;
        bool insideDomain = false;


        Console.Write("����һ�������ʼ���ַ: ");
        email = Console.ReadLine() ?? string.Empty;

        Console.Write("�õ�ַ������: ");

        #region INCLUDE
        // ����email��ַ�е�ÿ����ĸ
        foreach (char letter in email)
        {
            if(insideDomain)
            {
                Console.Write(letter);
            }
            else
            {
                if(letter == '@')
                {
                    insideDomain = true;
                }
            }
        }
        #endregion INCLUDE
    }
}
