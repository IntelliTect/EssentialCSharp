namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_01
{
    public struct Coordinate
    {
        public Coordinate(Longitude longitude, Latitude latitude)
        {
            _Longitude = longitude;
            _Latitude = latitude;
        }

        public Longitude Longitude { get { return _Longitude; } }
        private readonly Longitude _Longitude;

        public Latitude Latitude { get { return _Latitude; } }
        private readonly Latitude _Latitude;

        public override string ToString()
        {
            return string.Format("{0} {1}", Longitude, Latitude);
        }

        // ...
    }

    public struct Longitude{}
    public struct Latitude{}
}