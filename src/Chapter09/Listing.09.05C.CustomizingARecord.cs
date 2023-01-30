using System.Text;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_05C;

public readonly record struct Angle(int Degrees, int Minutes, int Seconds, string? Name = null)
{
    // Default constructor is not invoked unless
    // called explicitly by the instantiation.
    public Angle() : this(-42, 0, 0, null) { }

    public Angle(string degrees, string? minutes, string seconds)
        : this(degrees.Length, minutes!.Length, seconds.Length)
    {
    }
    
    public int Degrees { get; } = Degrees;

    private readonly int _Minutes = Minutes;
    public int Minutes
    {
        get => _Minutes;
        init => _Minutes=value;
    }
    
    private readonly int _Seconds = Seconds;
    public int Seconds
    {
        get => _Seconds;
        init => _Seconds=value;
    }

    public override readonly string ToString()
    {
        string prefix = 
            string.IsNullOrWhiteSpace(Name)?string.Empty : Name+": ";
        return $"{prefix}{Degrees}° {Minutes}' {Seconds}\"";
    }

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

