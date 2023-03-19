namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_54;

public class EmailDomain
{
    public static void Main()
    {
        string email;
        bool insideDomain = false;

        Console.WriteLine("Enter an email address: ");
        email = Console.ReadLine() ?? string.Empty;

        Console.Write("The email domain is: ");

        #region INCLUDE
        // Iterate through each letter in the email address
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
