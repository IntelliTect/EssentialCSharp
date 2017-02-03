namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_07
{
    using System;
    class Program
    {
        static void ChapterMain()
        {
            // ...

            Angle angle = new Angle(25, 58, 23);
            object objectAngle = angle;  // Box
            Console.Write(((Angle)objectAngle).Degrees);

            // Unbox, modify unboxed value, and discard value
            ((Angle)objectAngle).MoveTo(26, 58, 23);
            Console.Write(", " + ((Angle)objectAngle).Degrees);

            // Box, modify boxed value, and discard reference to box
            ((IAngle)angle).MoveTo(26, 58, 23);
            Console.Write(", " + ((Angle)angle).Degrees);

            // Modify boxed value directly
            ((IAngle)objectAngle).MoveTo(26, 58, 23);
            Console.WriteLine(", " + ((Angle)objectAngle).Degrees);

            // ...
        }
    }

    interface IAngle
    {
        void MoveTo(int hours, int minutes, int seconds);
    }

    struct Angle : IAngle
    {
        public Angle(int degrees, int minutes, int seconds)
        {
            _Degrees = degrees;
            _Minutes = minutes;
            _Seconds = seconds;
        }

        // NOTE:  This makes Angle mutable, against the general
        //        guideline
        public void MoveTo(int degrees, int minutes, int seconds)
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
    }
}
