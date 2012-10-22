namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_04
{
    struct Angle
    {
        public Angle(int hours, int minutes)
            : this(hours, minutes, default(int))
        {
        }

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
}
