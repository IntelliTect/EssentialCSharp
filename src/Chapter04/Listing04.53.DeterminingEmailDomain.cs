namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_53;

public class EmailDomain
{
    public static void Main()
    {
        #region INCLUDE
        string email;
        bool insideDomain = false;

        Console.Write("输入一个电子邮件地址: ");
        email = Console.ReadLine() ?? string.Empty;

        Console.Write("该地址的域是: ");

        // 遍历电邮地址中的每个字母
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
