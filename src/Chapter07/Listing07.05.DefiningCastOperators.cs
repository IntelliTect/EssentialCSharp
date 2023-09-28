#pragma warning disable IDE0060 // Remove unused parameter

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_05;

#region INCLUDE
class GpsCoordinates
{
    // ...

    public static implicit operator UtmCoordinates(
        GpsCoordinates coordinates)
    {
        #region EXCLUDE
        return null!; //return the new UtmCoordinates object
        #endregion EXCLUDE
    }
}
#endregion INCLUDE

class UtmCoordinates
{

}
