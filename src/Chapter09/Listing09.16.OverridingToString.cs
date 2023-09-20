namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_16;

public readonly struct Angle
{
    public int Degrees { get; init; }
    public int Minutes { get; init; }
    public int Seconds { get; init; }
    public string? Name { get; init; }
    public Angle(int Degrees, int Minutes, int Seconds, string? Name)
    {
        this.Degrees = Degrees;
        this.Minutes = Minutes;
        this.Seconds = Seconds;
        this.Name = Name;
    }

    #region INCLUDE
    public override string ToString()
    {
        string prefix =
            string.IsNullOrWhiteSpace(Name) ? string.Empty : Name + ": ";
        return $"{prefix}{Degrees}° {Minutes}' {Seconds}\"";
    }
    #endregion INCLUDE
}
