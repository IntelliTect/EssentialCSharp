namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_53
{
    public class EmailDomain
    {
        public static void Main()
        {
            string email;
            bool insideDomain = false;

            System.Console.WriteLine("Enter an email address: ");
            email = System.Console.ReadLine();

            System.Console.Write("The email domain is: ");

            // Iterate through each letter in the email address
            foreach(char letter in email)
            {
                if(insideDomain)
                {
                    System.Console.Write(letter);
                }
                else
                {
                    if(letter == '@')
                    {
                        insideDomain = true;
                    }
                }
            }
        }
    }
}
