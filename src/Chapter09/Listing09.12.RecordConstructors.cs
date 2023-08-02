namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_12;

public record struct Angle(
int Degrees, int Minutes, int Seconds, string? Name = null)
{

    #region INCLUDE
    public Angle(
        string degrees, string minutes, string seconds)
        : this(int.Parse(degrees),
               int.Parse(minutes), 
               int.Parse(seconds))
    { }
    #endregion INCLUDE
}
