// Justification: Invalid code commented out resulting in partial implementation
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_07
{
    using System;
    using System.IO;

    public class PdaItem
    {
        public PdaItem(Guid objectKey) => ObjectKey = objectKey;
        protected Guid ObjectKey { get; }
    }

    public class Contact : PdaItem
    {
        public Contact(Guid objectKey)
            : base(objectKey) { }

        public void Save()
        {
            // Instantiate a FileStream using <ObjectKey>.dat
            // for the filename
            using FileStream stream = File.OpenWrite(
                ObjectKey + ".dat");
            // ...
            stream.Dispose();
        }
        static public Contact Copy(Contact contact)
            => new Contact(contact.ObjectKey);

         // static public Contact Copy(PdaItem pdaItem) =>
            // Error: Cannot access protected member PdaItem.ObjectKey.
            // new Contact(((Contact)pdaItem).ObjectKey);
    }

    public class Program
    {
        public static void Main()
        {
            Contact contact = new Contact(Guid.NewGuid());

            // ERROR:  'PdaItem.ObjectKey' is inaccessible
            // Console.WriteLine(contact.ObjectKey);
        }
    }
}
