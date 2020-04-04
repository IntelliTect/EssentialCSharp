namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_19
{
    public class Program
    {
        public static void Main()
        {
            unsafe
            {
                Angle angle = new Angle(30, 18, 0);
                Angle* pAngle = &angle;
                System.Console.WriteLine("{0}* {1}' {2}\"",
                    pAngle->Hours, pAngle->Minutes, pAngle->Seconds);
            }
        }
    }

    public struct Angle
    {
        public Angle(short hours, short minutes, short seconds)
            : this()
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public short Hours { get; set; }
        public short Minutes { get; set; }
        public short Seconds { get; set; }
    }
}
