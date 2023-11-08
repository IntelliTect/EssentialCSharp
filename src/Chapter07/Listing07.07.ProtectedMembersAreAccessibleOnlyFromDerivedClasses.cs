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
    public static Contact Copy(Contact contact)
    #region HIGHLIGHT
        => new(contact.ObjectKey);
    #endregion HIGHLIGHT

    #if COMPILEERROR // EXCLUDE
    static public Contact Copy(PdaItem pdaItem) =>
    #region HIGHLIGHT
    // ERROR: Cannot access protected member PdaItem.ObjectKey.
    // Use ((Contact)pdaItem).ObjectKey instead.
        new(pdaItem.ObjectKey);
    #endregion HIGHLIGHT
    #endif // COMPILEERROR // EXCLUDE
}

public class Program
{
    public static void Main()
    {
        Contact contact = new(Guid.NewGuid());

        #region HIGHLIGHT
        #if COMPILEERROR // EXCLUDE
        // ERROR:  'PdaItem.ObjectKey' is inaccessible
        Console.WriteLine(contact.ObjectKey);
        #endif // COMPILEERROR // EXCLUDE
        #endregion HIGHLIGHT
    }
}
#endregion INCLUDE
