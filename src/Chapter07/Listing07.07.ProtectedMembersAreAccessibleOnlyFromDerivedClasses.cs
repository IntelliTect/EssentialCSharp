// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618 // Ignored pending constructor
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_07
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            Contact contact = new Contact
            {
                Name = "Inigo Montoya"
            };

            // ERROR:  'PdaItem.ObjectKey' is inaccessible
            // due to its protection level
            // contact.ObjectKey = Guid.NewGuid(); //uncomment this line and it will not compile
        }
    }

    public class PdaItem
    {
        protected Guid ObjectKey { get; set; }

        // ...
    }

    public class Contact : PdaItem
    {
        public void Save()
        {
            // Instantiate a FileStream using <ObjectKey>.dat
            // for the filename
            FileStream stream = System.IO.File.OpenWrite(
                ObjectKey + ".dat");
            // ...
            stream.Dispose();
        }

        static public Contact Load(PdaItem pdaItem)
        {
            if(pdaItem is Contact contact)
            {
                System.Diagnostics.Trace.WriteLine(
                    $"ObjectKey: {contact.ObjectKey}");
                return (Contact)pdaItem;
            }
            else
            {
                Contact newContact = new Contact();
                // ERROR:  'pdaItem.ObjectKey' is inaccessible
                // due to its protection level even though
                // contact.ObjectKey is.
                // contact.ObjectKey = pdaItem.ObjectKey;

                return newContact;
            }
        }

        // ...
        public string Name { get; set; }
    }
}
