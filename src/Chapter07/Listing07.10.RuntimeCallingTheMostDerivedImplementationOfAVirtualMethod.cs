namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_10
{
    using System;
    using Listing07_09;

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
            // properties were set
            Console.WriteLine(
                $"{ contact.FirstName } { contact.LastName}");
        }
    }
}
