// Justification: Listing is incomplete for purposes of elucidation.
#pragma warning disable IDE0060 // Remove unused parameter
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_04
{
    using System;

    public class Program
    {
        public static void Main()
        {
            //...

            Coordinate coordinate1 =
                new Coordinate(new Longitude(48, 52),
                               new Latitude(-2, -20));

            // Value types will never be reference equal.
            if(Coordinate.ReferenceEquals(coordinate1,
                coordinate1))
            {
                throw new Exception(
                    "coordinate1 reference equals coordinate1");
            }

            Console.WriteLine(
                "coordinate1 does NOT reference equal itself");
        }
    }

    public struct Coordinate
    {
        public Coordinate(Longitude longitude, Latitude latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }

        public Longitude Longitude { get; }
        public Latitude Latitude { get; }


        // ...
    }

    public struct Longitude
    {
        public Longitude(int x, int y) { }
    }
    public struct Latitude
    {
        public Latitude(int x, int y) { }
    }
}