namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_07;

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
        => new(contact.ObjectKey);
    #endregion HIGHLIGHT

    #if COMPILEERROR
    static public Contact Copy(PdaItem pdaItem) =>
    #region HIGHLIGHT
    // ERROR: Cannot access protected member PdaItem.ObjectKey.
    // Use ((Contact)pdaItem).ObjectKey instead.
        new(pdaItem.ObjectKey);
    #endregion HIGHLIGHT
    #endif // COMPILEERROR
}

public class Program
{
    public static void Main()
    {
        Contact contact = new(Guid.NewGuid());

        #region HIGHLIGHT
        #if COMPILEERROR
        // ERROR:  'PdaItem.ObjectKey' is inaccessible
        Console.WriteLine(contact.ObjectKey);
        #endif // COMPILEERROR
        #endregion HIGHLIGHT
    }
}
#endregion INCLUDE
