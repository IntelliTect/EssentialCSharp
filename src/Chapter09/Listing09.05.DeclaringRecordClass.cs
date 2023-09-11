using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_02;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_05;
#region INCLUDE
// Use the record class construct to declare a reference type
public record class Coordinate(
    Angle Longitude, Angle Latitude)
#endregion INCLUDE
{
    public Type ExternalEqualityContract => EqualityContract;
}
