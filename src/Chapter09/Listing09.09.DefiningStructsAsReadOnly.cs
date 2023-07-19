namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_09;

public record struct Angle
{
    public int Degrees { get; }
    public int Minutes { get; }
    public int Seconds { get; }

    public Angle(int Degrees, int Minutes, int Seconds)
    {
        this.Degrees = Degrees;
        this.Minutes = Minutes;
        this.Seconds = Seconds;
    }

    #region INCLUDE
    public readonly Angle Move(int degrees, int minutes, int seconds)
    {
        return new Angle(
            Degrees + degrees,
            Minutes + minutes,
            Seconds + seconds);
    }
    #endregion INCLUDE

    public void Deconstruct(
        out int Degrees, out int Minutes, out int Seconds)
    {
        Degrees = this.Degrees;
        Minutes = this.Minutes;
        Seconds = this.Seconds;
    }
}
