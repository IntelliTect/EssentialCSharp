namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_53;

public class EmailDomain
{
    public static void Main()
    {
        #region INCLUDE
        string email;
        bool insideDomain = false;

        Console.Write("����һ�������ʼ���ַ: ");
        email = Console.ReadLine() ?? string.Empty;

        Console.Write("�õ�ַ������: ");

        // �������ʵ�ַ�е�ÿ����ĸ
        foreach(char letter in email)
        {
            if(!insideDomain)
            {
                if(letter == '@')
                {
                    insideDomain = true;
                }
                continue;
            }

            Console.Write(letter);
        }
        #endregion INCLUDE
    }
}
