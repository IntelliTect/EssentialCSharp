// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618 // Disabled pending constructors

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_14;

#region INCLUDE
using static System.Environment;

public class Address
{
    public string StreetAddress;
    public string City;
    public string State;
    public string Zip;

    public override string ToString()
    {
        return $"{ StreetAddress + NewLine }"
            + $"{ City }, { State }  { Zip }";
    }
}

public class InternationalAddress : Address
{
    public string Country;

    public override string ToString()
    {
        #region HIGHLIGHT
        return base.ToString() +
        #endregion HIGHLIGHT
            NewLine + Country;
    }
}
#endregion INCLUDE
