﻿namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_01;

#region INCLUDE
// Use keyword struct to declare a value type
#region HIGHLIGHT
readonly public struct Angle
#endregion HIGHLIGHT
{
    public Angle(int degrees, int minutes, int seconds)
    {
        Degrees = degrees;
        Minutes = minutes;
        Seconds = seconds;
    }

    public int Degrees { get; }
    public int Minutes { get; }
    public int Seconds { get; }

    public Angle Move(int degrees, int minutes, int seconds)
    {
        return new Angle(
            Degrees + degrees,
            Minutes + minutes,
            Seconds + seconds);
    }
}

// Declaring a class as a reference type
// (declaring it as a struct would create a value type
// larger than 16 bytes.)
class Coordinate
{
    public Angle Longitude { get; set; }

    public Angle Latitude { get; set; }
}
#endregion INCLUDE
