namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_24;

#region INCLUDE
public readonly record struct Angle(
    int Degrees, int Minutes, int Seconds, string? Name = null)
{

    public int Degrees { get; } = Degrees;

    public Angle(
        string degrees, string minutes, string seconds)
        : this(int.Parse(degrees), 
              int.Parse(minutes), int.Parse(seconds))
    {
    }
    
    public override readonly string ToString()
    {
        string prefix = 
            string.IsNullOrWhiteSpace(Name)?string.Empty : Name+": ";
        return $"{prefix}{Degrees}° {Minutes}' {Seconds}\"";
    }

    // Changing Equals() to ignore Name
    public bool Equals(Angle other) =>
        (Degrees, Minutes, Seconds).Equals(
            (other.Degrees, other.Minutes, other.Seconds));

    public override int GetHashCode() =>
        HashCode.Combine(Degrees.GetHashCode(), 
            Minutes.GetHashCode(), Seconds.GetHashCode);

    #if UsingTupleToGenerateHashCode
    public override int GetHashCode() => 
        (Degrees, Minutes, Seconds).GetHashCode();
    #endif // UsingTupleToGenerateHashCode        
}
#endregion INCLUDE
