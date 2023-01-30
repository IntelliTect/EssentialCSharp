namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_04.Tests;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_01;

public partial class CoordinateTests
{
    public record class GeoCoordinate(Angle Longitude, Angle Latitude, string Name) : Coordinate(Longitude, Latitude)
    {
        public new Type ExternalEqualityContract => EqualityContract;
    }
}
