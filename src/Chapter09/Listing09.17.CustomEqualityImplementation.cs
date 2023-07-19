namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_17;

public readonly record struct Angle(
    int Degrees, int Minutes, int Seconds, string? Name = null)
{
    // Changing Equals() to ignore Name
    #region INCLUDE
    public bool Equals(Angle other) =>
        (Degrees, Minutes, Seconds).Equals(
            (other.Degrees, other.Minutes, other.Seconds));
    #endregion INCLUDE  
}
