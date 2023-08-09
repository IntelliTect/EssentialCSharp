using System.Runtime.CompilerServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_14;

[CompilerGenerated]
public readonly struct Angle : IEquatable<Angle>
{
    public int Degrees { get; init; }
    public int Minutes { get; init; }
    public int Seconds { get; init; }
    public Angle(int Degrees, int Minutes, int Seconds)
    {
        this.Degrees = Degrees;
        this.Minutes = Minutes;
        this.Seconds = Seconds;
    }

    public override int GetHashCode()
    {
        static int GetHashCode(int integer) =>
            EqualityComparer<int>.Default.GetHashCode(integer);

        return GetHashCode(Degrees) * -1521134295
            + GetHashCode(Minutes) * -1521134295
            + GetHashCode(Seconds) * -1521134295;
    }

    public override bool Equals(object? obj) =>
        obj is Angle angle && Equals(angle);

    public bool Equals(Angle other) =>
        EqualityComparer<int>.Default.Equals(Degrees, other.Degrees)
        && EqualityComparer<int>.Default.Equals(Minutes, other.Minutes)
        && EqualityComparer<int>.Default.Equals(Seconds, other.Seconds);

    #region INCLUDE
    public void Deconstruct(
        out int Degrees, out int Minutes, out int Seconds)
    {
        Degrees = this.Degrees;
        Minutes = this.Minutes;
        Seconds = this.Seconds;
    }
    #endregion INCLUDE
}
