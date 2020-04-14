namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_07
{
    public struct Arc
    {
        public Arc(
            Longitude longitudeDifference,
            Latitude latitudeDifference)
        {
            LongitudeDifference = longitudeDifference;
            LatitudeDifference = latitudeDifference;
        }

        public Longitude LongitudeDifference { get; }
        public Latitude LatitudeDifference { get; }

    }

    public struct Coordinate
    {
        public Coordinate(Longitude longitude, Latitude latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }

        public static Coordinate operator +(
            Coordinate source, Arc arc)
        {
            Coordinate result = new Coordinate(
                new Longitude(
                    source.Longitude + arc.LongitudeDifference),
                new Latitude(
                    source.Latitude + arc.LatitudeDifference));
            return result;
        }

        public static Coordinate operator -(
            Coordinate source, Arc arc)
        {
            Coordinate result = new Coordinate(
                new Longitude(
                    source.Longitude - arc.LongitudeDifference),
                new Latitude(
                    source.Latitude - arc.LatitudeDifference));
            return result;
        }

        public static bool operator ==(
              Coordinate leftHandSide,
              Coordinate rightHandSide)
        {

            // There is no need to check of null in this 
            // case because Coordinate is a valye type.
            return (leftHandSide.Equals(rightHandSide));
        }

        public static bool operator !=(
            Coordinate leftHandSide,
            Coordinate rightHandSide)
        {
            return !(leftHandSide == rightHandSide);
        }

        public override bool Equals(object? obj)
        {
            // STEP 1: Check for null
            if (obj is null)
            {
                return false;
            }
            // STEP 3: equivalent data types
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
            // is a reference type
            // if ( ReferenceEquals(this, obj))
            // {
            //   return true;
            // }

            // STEP 4: Possibly check for equivalent hash codes
            // if (this.GetHashCode() != obj.GetHashCode())
            // {
            //    return false;
            // } 

            // STEP 5: Check base.Equals if base overrides Equals()
            // System.Diagnostics.Debug.Assert(
            //     base.GetType() != typeof(object) );
            // if ( !base.Equals(obj) )
            // {
            //    return false;
            // } 

            // STEP 6: Compare identifying fields for equality
            //         using an overload of Equals on Longitude
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



        public Longitude Longitude { get; }
        public Latitude Latitude { get; }


        public override string ToString()
        {
            return string.Format("{0}° {1}' 0 E {2}° {3}' 0 N", Longitude.Degrees, Longitude.Minutes, Latitude.Degrees, Latitude.Minutes);
        }
    }

    public struct Longitude
    {
        public Longitude(int degrees, int minutes)
        {
            Degrees = degrees;
            Minutes = minutes;
        }

        public Longitude(int degrees)
            : this(degrees, 0) { }

        public Longitude(Longitude longitude)
            : this(longitude.Degrees, longitude.Minutes) { }


        public int Degrees { get; }
        public int Minutes { get; }

        public static Longitude operator +(Longitude leftHandSide, Longitude rightHandSide)
        {
            return new Longitude(leftHandSide.Degrees + rightHandSide.Degrees, leftHandSide.Minutes + rightHandSide.Minutes);
        }

        public static Longitude operator -(Longitude leftHandSide, Longitude rightHandSide)
        {
            return new Longitude(leftHandSide.Degrees - rightHandSide.Degrees, leftHandSide.Minutes - rightHandSide.Minutes);
        }
    }

    public struct Latitude
    {
        public Latitude(int degrees, int minutes)
        {
            Degrees = degrees;
            Minutes = minutes;
        }

        public Latitude(int degrees)
            : this(degrees, 0) { }

        public Latitude(Latitude Latitude)
            : this(Latitude.Degrees, Latitude.Minutes) { }

        public int Degrees { get; }
        public int Minutes { get; }


        public static Latitude operator +(Latitude leftHandSide, Latitude rightHandSide)
        {
            return new Latitude(leftHandSide.Degrees + rightHandSide.Degrees, leftHandSide.Minutes + rightHandSide.Minutes);
        }

        public static Latitude operator -(Latitude leftHandSide, Latitude rightHandSide)
        {
            return new Latitude(leftHandSide.Degrees - rightHandSide.Degrees, leftHandSide.Minutes - rightHandSide.Minutes);
        }
    }
}