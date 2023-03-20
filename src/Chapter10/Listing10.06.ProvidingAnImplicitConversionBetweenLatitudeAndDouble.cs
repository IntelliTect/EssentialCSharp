namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_06;

#region INCLUDE
public readonly struct Latitude
{
    // ...

    public Latitude(double decimalDegrees)
    {
        DecimalDegrees = Normalize(decimalDegrees);
    }

    public double DecimalDegrees { get; }

    // ...

    public static implicit operator double(Latitude latitude)
    {
        return latitude.DecimalDegrees;
    }
    public static implicit operator Latitude(double degrees)
    {
        return new Latitude(degrees);
    }

    #region EXCLUDE
    private static double Normalize(double decimalDegrees)
    {
        // here you would normalize the data
        return decimalDegrees;
    }
    #endregion EXCLUDE
}
#endregion INCLUDE
