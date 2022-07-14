#pragma warning disable IDE0060 // Remove unused parameter

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_05
{
    #region INCLUDE
    class GPSCoordinates
    {
        // ...

        public static implicit operator UTMCoordinates(
            GPSCoordinates coordinates)
        {
            #region EXCLUDE
            return null!; //return the new UTMCoordinates object
            #endregion EXCLUDE
        }
    }
    #endregion INCLUDE

    class UTMCoordinates
    {

    }
}
