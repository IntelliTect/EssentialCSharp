namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_07;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_01;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_04;

#region INCLUDE
public record class NamedCoordinate(
    Angle Longitude, Angle Latitude, string Name)
    : Coordinate(Longitude, Latitude);
#endregion INCLUDE
