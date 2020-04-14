using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_02
{
    public struct Coordinate
    {
        public Coordinate(Longitude longitude, Latitude latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }

        public Longitude Longitude { get; }
        public Latitude Latitude { get; }


        public override int GetHashCode() => 
            HashCode.Combine(Longitude.GetHashCode(), Latitude.GetHashCode());

        public override string ToString() =>
            $"{ Longitude } { Latitude }";

    }

    public struct Longitude { }
    public struct Latitude { }
}