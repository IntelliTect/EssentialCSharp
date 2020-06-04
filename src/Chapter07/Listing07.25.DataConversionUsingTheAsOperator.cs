namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_25
{
    using System;

    public class PdaItem
    {
        protected Guid ObjectKey { get; }

        // ...
    }

    public class Contact : PdaItem
    {

        public Contact(string name) => Name = name;

        static public Contact Load(PdaItem pdaItem)
        {
#pragma warning disable IDE0019 // Use pattern matching
            Contact? contact = pdaItem as Contact;
#pragma warning restore IDE0019 // Use pattern matching
            if (contact != null)
            {
                System.Diagnostics.Trace.WriteLine(
                    $"ObjectKey: {contact.ObjectKey}");
                return (Contact)pdaItem;
            }
            else
            {
                throw new ArgumentException(
                    $"{nameof(pdaItem)} was not of type {nameof(Contact)}");
            }
        }

        // ...
        public string Name { get; set; }
    }
}
