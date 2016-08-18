namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_01
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


        public override string ToString()
        {
            return $"{ Longitude } { Latitude }";
        }

        // ...
    }

    public struct Longitude { }
    public struct Latitude { }
}