namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_02
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

        public override int GetHashCode()
        {
            int hashCode = Longitude.GetHashCode();
            // As long as the hash codes are not equal
            if (Longitude.GetHashCode() != Latitude.GetHashCode())
            {
                hashCode ^= Latitude.GetHashCode();  // eXclusive OR
            }
            return hashCode;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Longitude, Latitude);
        }

    }

    public struct Longitude{}
    public struct Latitude{}
}