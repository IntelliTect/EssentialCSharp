namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_01
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
        public override string ToString() =>
            $"{ Longitude } { Latitude }";
        #endregion HIGHLIGHT

        // ...
    }
    #endregion INCLUDE

    public struct Longitude { }
    public struct Latitude { }
}