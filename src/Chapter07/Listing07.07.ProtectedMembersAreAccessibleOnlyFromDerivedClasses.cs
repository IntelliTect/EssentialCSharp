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
        // 使用<ObjectKey>.dat作为文件名来实例化一个FileStream
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
    // 错误：不能访问受保护成员PdaItem.ObjectKey。
    // 改为使用((Contact)pdaItem).ObjectKey
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
        // 错误:  'PdaItem.ObjectKey'不可访问
        Console.WriteLine(contact.ObjectKey);
#endif // COMPILEERROR // EXCLUDE
        #endregion HIGHLIGHT
    }
}
#endregion INCLUDE
