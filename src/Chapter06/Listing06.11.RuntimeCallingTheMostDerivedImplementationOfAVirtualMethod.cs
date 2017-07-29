namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_11
{
    using System;
    using Listing06_10;

    public class Program
    {
        public static void Main()
        {
            Contact contact;
            PdaItem item;

            contact = new Contact();
            item = contact;

            // Set the name via PdaItem variable
            item.Name = "Inigo Montoya";

            // Display that FirstName & LastName
            // properties were set.
            Console.WriteLine(
                $"{ contact.FirstName } { contact.LastName}");

        }
    }
}
