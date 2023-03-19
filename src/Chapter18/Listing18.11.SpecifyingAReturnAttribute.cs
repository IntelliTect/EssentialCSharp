namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_11;

public class Program
{
#pragma warning disable CA1822 // Mark members as static
    #region INCLUDE
    [return: Description(
       "Returns true if the object is in a valid state.")]
    public bool IsValid()
    {
        // ...
        return true;
    }
    #endregion INCLUDE
#pragma warning restore CA1822 // Mark members as static
}

public class DescriptionAttribute : Attribute
{
    private readonly string _Description;
    public string Description { get { return _Description; } }

    public DescriptionAttribute(string description)
    {
        this._Description = description;
    }
}