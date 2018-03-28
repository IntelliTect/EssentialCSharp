namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_05
{
    class GPSCoordinates
    {
        // ...

        public static implicit operator UTMCoordinates(
            GPSCoordinates coordinates)
        {
            // ...
            return null;//return the new UTMCoordinates object
        }
    }

    class UTMCoordinates
    {

    }
}
