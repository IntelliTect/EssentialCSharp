// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618 // Ignored pending constructor
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_25
{
    using System;
    using System.IO;

    public class PdaItem
    {
        protected Guid ObjectKey { get; set; }

        // ...
    }

    public class Contact : PdaItem
    {

        // ...

        static public Contact Load(PdaItem pdaItem)
        {
            #pragma warning disable IDE0019 // Use pattern matching
            Contact? contact = pdaItem as Contact;
            if (contact != null)
            {
                System.Diagnostics.Trace.WriteLine(
                    $"ObjectKey: {contact.ObjectKey}");
                return (Contact)pdaItem;
            }
            else
            {
                Contact newContact = new Contact();

                // ...

                return newContact;
            }
        }

        // ...
        public string Name { get; set; }
    }
}
