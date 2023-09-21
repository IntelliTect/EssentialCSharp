namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_23;

#region INCLUDE
/*
[Flags]
public enum FileAttributes
{
    ReadOnly = 0x0001,
    Hidden   = 0x0002,
    // ...
}
*/

public class Program
{
    public static void Main()
    {
        // ...
        string fileName = @"enumtest.txt";
        FileInfo file = new(fileName);

        file.Attributes = FileAttributes.Hidden |
            FileAttributes.ReadOnly;

        Console.WriteLine("\"{0}\" outputs as \"{1}\"",
            file.Attributes.ToString().Replace(",", " |"),
            file.Attributes);

        FileAttributes attributes =
            (FileAttributes)Enum.Parse(typeof(FileAttributes),
            file.Attributes.ToString());

        Console.WriteLine(attributes);

        // ...
    }
}
#endregion INCLUDE
