using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_02;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_05;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_07;

#region INCLUDE
public record class NamedCoordinate(
    Angle Longitude, Angle Latitude, string Name)
    : Coordinate(Longitude, Latitude);

#endregion INCLUDE
