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


        public override int GetHashCode()
        {
            int hashCode = Longitude.GetHashCode();
            // As long as the hash codes are not equal
            if(Longitude.GetHashCode() != Latitude.GetHashCode())
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

    public struct Longitude { }
    public struct Latitude { }
}