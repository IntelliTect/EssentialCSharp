namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_53;

public class EmailDomain
{
    public static void Main()
    {
        #region INCLUDE
        string email;
        bool insideDomain = false;

        Console.Write("Enter an email address: ");
        email = Console.ReadLine() ?? string.Empty;

        Console.Write("The email domain is: ");

        // Iterate through each letter in the email address
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
