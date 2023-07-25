using System.Runtime.CompilerServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_22;

public class Angle
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

    public Angle(int Degrees, int Minutes, int Seconds)
    {
        this.Degrees = Degrees;
        this.Minutes = Minutes;
        this.Seconds = Seconds;
        this.Name = null;
    }

    #region INCLUDE
    public override int GetHashCode() =>
        HashCode.Combine(Degrees, Minutes, Seconds);
    #endregion INCLUDE

    public override bool Equals(object? obj) =>
        Equals(obj as Angle);

    public bool Equals(Angle? other)
    {
        if (other == null) return false;
        return
        EqualityComparer<int>.Default.Equals(Degrees, other.Degrees)
        && EqualityComparer<int>.Default.Equals(Minutes, other.Minutes)
        && EqualityComparer<int>.Default.Equals(Seconds, other.Seconds)
        && EqualityComparer<string>.Default.Equals(Name, other.Name);
    }
    public void Deconstruct(
        out int Degrees, out int Minutes, out int Seconds, out string? Name)
    {
        Degrees = this.Degrees;
        Minutes = this.Minutes;
        Seconds = this.Seconds;
        Name = this.Name;
    }
}
