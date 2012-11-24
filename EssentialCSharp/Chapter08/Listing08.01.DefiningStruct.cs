namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_01
{
    // Use keyword struct to declare a value type.
    struct Angle
    {
        public Angle(int degrees, int minutes, int seconds)
        {
            _Degrees = degrees;
            _Minutes = minutes;
            _Seconds = seconds;
        }

        public int Degrees
        {
            get { return _Degrees; }
        }
        private int _Degrees;

        public int Minutes
        {
            get { return _Minutes; }
        }
        private int _Minutes;

        public int Seconds
        {
            get { return _Seconds; }
        }
        private int _Seconds;

        public Angle Move(int degrees, int minutes, int seconds)
        {
            return new Angle(
                Degrees + degrees,
                Minutes + minutes,
                Seconds + seconds);
        }
    }

    // Declaring a class - a reference type
    // (declaring it as a struct would create a value type
    // larger than 16 bytes.)
    class Coordinate
    {
        public Angle Longitude
        {
            get { return _Longitude; }
            set { _Longitude = value; }
        }
        private Angle _Longitude;

        public Angle Latitude
        {
            get { return _Latitude; }
            set { _Latitude = value; }
        }
        private Angle _Latitude;
    }
}