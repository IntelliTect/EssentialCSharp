namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_04
{
    struct Angle
    {
        public Angle(int hours, int minutes)
            : this(hours, minutes, default(int))
        {
        }

        public Angle(int degrees, int minutes, int seconds)
        {
            Degrees = degrees;
            Minutes = minutes;
            Seconds = seconds;
        }

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
}
