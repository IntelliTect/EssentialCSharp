// Justification: Invalid code commented out resulting in partial implementation
#pragma warning disable IDE0059 // Unnecessary assignment of a value


namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_06;

#region INCLUDE
public class PdaItem
{
    #region EXCLUDE
    // Justification: Disabled pending constructor
    #pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
    #endregion EXCLUDE
    private string _Name;

    public string Name
    {
        get { return _Name; }
        set { _Name = value; }
    }
    #region EXCLUDE
    #pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
    #endregion EXCLUDE
}

public class Contact : PdaItem
{
    // ...
}

public class Program
{
    public static void Main()
    {
        Contact contact = new();
        #region HIGHLIGHT
        #if COMPILEERROR // EXCLUDE
        // ERROR:  'PdaItem._Name' is inaccessible
        // due to its protection level
        contact._Name = "Inigo Montoya";
        #endif // COMPILEERROR // EXCLUDE
        #endregion HIGHLIGHT
    }
}
#endregion INCLUDE
