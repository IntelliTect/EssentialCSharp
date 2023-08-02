using System.Runtime.CompilerServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_19;

public readonly struct Angle : IEquatable<Angle>
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

    public override int GetHashCode()
    {
        static int GetHashCode(int integer) =>
            EqualityComparer<int>.Default.GetHashCode(integer);

        return GetHashCode(Degrees) * -1521134295
            + GetHashCode(Minutes) * -1521134295
            + GetHashCode(Seconds) * -1521134295
            + EqualityComparer<string>.Default.GetHashCode(Name!);
    }

    #region INCLUDE
    public override bool Equals(object? obj)
    #endregion INCLUDE 
        => obj is Angle angle && Equals(angle);

    public bool Equals(Angle other) =>
        EqualityComparer<int>.Default.Equals(Degrees, other.Degrees)
        && EqualityComparer<int>.Default.Equals(Minutes, other.Minutes)
        && EqualityComparer<int>.Default.Equals(Seconds, other.Seconds)
        && EqualityComparer<string>.Default.Equals(Name, other.Name);

    public void Deconstruct(
        out int Degrees, out int Minutes, out int Seconds, out string? Name)
    {
        Degrees = this.Degrees;
        Minutes = this.Minutes;
        Seconds = this.Seconds;
        Name = this.Name;
    }
}
