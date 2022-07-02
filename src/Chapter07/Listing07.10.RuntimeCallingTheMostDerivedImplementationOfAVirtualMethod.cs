namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_10
{
    using Listing07_09;
    using System;

    #region INCLUDE
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
                $"{contact.FirstName} {contact.LastName}");
        }
    }
    #endregion
}
