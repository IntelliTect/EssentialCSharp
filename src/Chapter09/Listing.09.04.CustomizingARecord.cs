using System.Text;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_04;

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
    
    public bool Equals(Angle other)
    {
        return EqualityComparer<int>.Default.Equals(Degrees, other.Degrees)
            && EqualityComparer<int>.Default.Equals(_Minutes, other._Minutes)
            && EqualityComparer<int>.Default.Equals(_Seconds, other._Seconds);
    }

    public override int GetHashCode() =>
        HashCode.Combine(Degrees.GetHashCode(), 
            Minutes.GetHashCode(), Seconds.GetHashCode);

#if UsingTupleToGenerateHashCode
    public override int GetHashCode() => 
        (Degrees, Minutes, Seconds).GetHashCode();
#endif // UsingTupleToGenerateHashCode        
}

