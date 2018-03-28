namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_02
{
    // Use keyword struct to declare a value type 
    struct Angle
    {
        public Angle(int degrees, int minutes, int seconds)
        {
            Degrees = degrees;
            Minutes = minutes;
            Seconds = seconds;
        }

        // ERROR:  Fields cannot be initialized at declaration time
        // private int _Degrees = 42;

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