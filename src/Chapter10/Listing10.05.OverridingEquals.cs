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

            // Value types will never be reference equal
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

    public struct Coordinate : IEquatable<Coordinate>
    {
        public Coordinate(Longitude longitude, Latitude latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }

        public Longitude Longitude { get; }
        public Latitude Latitude { get; }

        public override bool Equals(object obj)
        {
            // STEP 1: Check for null
            if (obj == null)
            {
                return false;
            }
            // STEP 3: Equivalent data types
            if (this.GetType() != obj.GetType())
            {
                return false;
            }
            return Equals((Coordinate)obj);
        }

        public bool Equals(Coordinate obj)
        {
            // STEP 1: Check for null if a reference type
            // (e.g., a reference type)
            // if (obj == null)
            // {
            //     return false;
            // }

            // STEP 2: Check for ReferenceEquals if this 
            // is a reference type.
            // if ( ReferenceEquals(this, obj))
            // {
            //   return true;
            // }

            // STEP 4: Possibly check for equivalent hash codes.
            // if (this.GetHashCode() != obj.GetHashCode())
            // {
            //    return false;
            // } 

            // STEP 5: Check base.Equals if base overrides Equals().
            // System.Diagnostics.Debug.Assert(
            //     base.GetType() != typeof(object) );
            // if ( !base.Equals(obj) )
            // {
            //    return false;
            // } 

            // STEP 6: Compare identifying fields for equality
            // using an overload of Equals on Longitude
            return ((Longitude.Equals(obj.Longitude)) &&
                (Latitude.Equals(obj.Latitude)));
        }

        // STEP 7: Override GetHashCode
        public override int GetHashCode()
        {
            int hashCode = Longitude.GetHashCode();
            hashCode ^= Latitude.GetHashCode(); // Xor (eXclusive OR)
            return hashCode;
        }
        public static bool operator ==(
            Coordinate leftHandSide,
            Coordinate rightHandSide)
        {
            return (leftHandSide.Equals(rightHandSide));
        }

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