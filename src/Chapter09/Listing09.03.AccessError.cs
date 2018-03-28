namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_03
{
    // Use keyword struct to declare a value type
    struct Angle
    {
        // ERROR:  The 'this' object cannot be used before
        //         all of its fields are assigned to
        // public Angle(int degrees, int minutes, int seconds)
        // {
        //     Degrees = degrees;    // Shorthand for this.Hours = hours;
        //     Minutes = minutes; // Shorthand for this.Minutes = ...;
        //     Seconds = seconds; // Shorthand for this.Seconds = ...;
        // }

        public Angle(int degrees, int minutes, int seconds)
        {
            _Degrees = degrees; // Shorthand for this.Degrees = ...;
            _Minutes = minutes; // Shorthand for this.Minutes = ...;
            _Seconds = seconds; // Shorthand for this.Seconds = ...;
        }

        public int Degrees { get { return _Degrees; } }
        readonly private int _Degrees;

        public int Minutes { get { return _Minutes; } }
        readonly private int _Minutes;

        public int Seconds { get { return _Seconds; } }
        readonly private int _Seconds;

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