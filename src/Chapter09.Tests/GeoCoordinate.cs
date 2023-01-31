namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Tests;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_01;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_03A;

public record class GeoCoordinate(Angle Longitude, Angle Latitude, string Name) 
    : Coordinate(Longitude, Latitude)
{
    public new Type ExternalEqualityContract => EqualityContract;
}
