using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_01;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_04;
#region INCLUDE
// Use the record struct construct to declare a value type
public record class Coordinate(Angle Longitude, Angle Latitude)
#endregion INCLUDE
{
    public Type ExternalEqualityContract => EqualityContract;
}