using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_02
{
    #region INCLUDE
    public struct Coordinate
    {
        public Coordinate(Longitude longitude, Latitude latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }

        public Longitude Longitude { get; }
        public Latitude Latitude { get; }

        #region HIGHLIGHT
        public override int GetHashCode() => 
            HashCode.Combine(
                Longitude.GetHashCode(), Latitude.GetHashCode());
        #endregion HIGHLIGHT

        #region EXCLUDE
        public override string ToString() =>
            $"{ Longitude } { Latitude }";
        #endregion EXCLUDE
    }
    #endregion INCLUDE

    public struct Longitude { }
    public struct Latitude { }
}