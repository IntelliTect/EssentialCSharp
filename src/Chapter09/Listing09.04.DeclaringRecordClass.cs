using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_01;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_04;

public record class Coordinate(Angle Longitude, Angle Latitude)
{
    public Type ExternalEqualityContract => EqualityContract;
}
