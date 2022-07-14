// Justification: Invalid code commented out resulting in partial implementation
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_07
{
    using System;
    #region INCLUDE
    using System.IO;

    public class PdaItem
    {
        public PdaItem(Guid objectKey) => ObjectKey = objectKey;
        #region HIGHLIGHT
        protected Guid ObjectKey { get; }
        #endregion HIGHLIGHT
    }

    public class Contact : PdaItem
    {
        public Contact(Guid objectKey)
            : base(objectKey) { }

        public void Save()
        {
            // Instantiate a FileStream using <ObjectKey>.dat
            // for the filename
            #region HIGHLIGHT
            using FileStream stream = File.OpenWrite(
                ObjectKey + ".dat");
            #endregion HIGHLIGHT
            // ...
            stream.Dispose();
        }
        static public Contact Copy(Contact contact)
        #region HIGHLIGHT
            => new Contact(contact.ObjectKey);
        #endregion HIGHLIGHT

        // static public Contact Copy(PdaItem pdaItem) =>
        #region HIGHLIGHT
        // Error: Cannot access protected member PdaItem.ObjectKey.
        // new Contact(((Contact)pdaItem).ObjectKey);
        #endregion HIGHLIGHT
    }

    public class Program
    {
        public static void Main()
        {
            Contact contact = new Contact(Guid.NewGuid());

            #region HIGHLIGHT
            // ERROR:  'PdaItem.ObjectKey' is inaccessible
            // Console.WriteLine(contact.ObjectKey);
            #endregion HIGHLIGHT
        }
    }
    #endregion INCLUDE
}
