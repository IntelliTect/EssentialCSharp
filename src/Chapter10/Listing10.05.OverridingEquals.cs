// Justification: Listing is incomplete for purposes of elucidation.
#pragma warning disable IDE0060 // Remove unused parameter
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_05
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
        }
    }

    public struct Coordinate : IEquatable<Coordinate>
    {
        public Coordinate(Longitude longitude, Latitude latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }

        public Longitude Longitude { get; }
        public Latitude Latitude { get; }

        public override bool Equals(object? obj)
        {
            // STEP 1: Check for null
            if (obj is null)
            {
                return false;
            }
            // STEP 2: Equivalent data types
            // can be avoided if type is sealed
            if (this.GetType() != obj.GetType())
            {
                return false;
            }

            // STEP 3: Invoked strongly type helper version of Equals()
            return Equals((Coordinate)obj);
        }

        public bool Equals(Coordinate obj)
        {
            // STEP 1: Check for null if a reference type
            // (e.g., a reference type)
            // if (ReferenceEquals(obj, null)
            // {
            //     return false;
            // }

            // STEP 4: Possibly check for equivalent hash codes
            // but not if the identity properties are mutable 
            // and the hash code is cached.
            // if (GetHashCode() != obj.GetHashCode())
            // {
            //    return false;
            // } 

            // STEP 5: Check base.Equals if base overrides Equals().
            if (!base.Equals(obj))
            {
                return false;
            }

            // STEP 6: Compare identifying fields for equality
            // using an overload of Equals on Longitude
            return ((Longitude.Equals(obj.Longitude)) &&
                (Latitude.Equals(obj.Latitude)));
        }

        // STEP 7: Override GetHashCode
        public override int GetHashCode() =>
            HashCode.Combine(Longitude.GetHashCode(), Latitude.GetHashCode());

        // STEP 8: Override the ==/!= operators
        public static bool operator ==(
            Coordinate leftHandSide,
            Coordinate rightHandSide)
        {
            return (leftHandSide.Equals(rightHandSide));
        }

        // STEP 8: Override the ==/!= operators
        public static bool operator !=(
            Coordinate leftHandSide,
            Coordinate rightHandSide)
        {
            return !(leftHandSide.Equals(rightHandSide));
        }
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