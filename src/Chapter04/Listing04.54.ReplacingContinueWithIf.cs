namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_54;

public class EmailDomain
{
    public static void Main()
    {
        string email;
        bool insideDomain = false;


        Console.Write("输入一个电子邮件地址: ");
        email = Console.ReadLine() ?? string.Empty;

        Console.Write("该地址的域是: ");

        #region INCLUDE
        // 遍历email地址中的每个字母
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
