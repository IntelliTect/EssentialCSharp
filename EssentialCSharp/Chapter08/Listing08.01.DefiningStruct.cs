﻿namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_01
{
    // Use keyword struct to declare a value type.
    struct Angle
    {
        public Angle(int degrees, int minutes, int seconds)
        {
            Degrees = degrees;
            Minutes = minutes;
            Seconds = seconds;
        }

        // Using C# 6.0 read-only, automatically implememted properties.
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

    // Declaring a class--a reference type
    // (declaring it as a struct would create a value type
    // larger than 16 bytes.)
    class Coordinate
    {
        public Angle Longitude { get; set; }

        public Angle Latitude { get; set; }
    }

}