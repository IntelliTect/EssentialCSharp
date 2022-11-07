namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_52
{
    #region INCLUDE
    public class EmailDomain
    {
        public static void Main()
        {
            string email;
            bool insideDomain = false;

            Console.WriteLine("Enter an email address: ");
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
        }
    }
    #endregion INCLUDE
}