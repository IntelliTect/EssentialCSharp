using System.Runtime.CompilerServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_18;

public class Coordinate : IEquatable<Coordinate>
{
    public Angle Longitude { get; init; }
    public Angle Latitude { get; init; }

    public Coordinate(Angle Longitude, Angle Latitude) :
        base()
    {
        this.Longitude = Longitude;
        this.Latitude = Latitude;
    }

    public static bool operator !=(Coordinate? left, Coordinate? right) =>
        !(left == right);

    #region INCLUDE
    public static bool operator ==(Coordinate? left, Coordinate? right) =>
        ReferenceEquals(left, right) || (left?.Equals(right) ?? false);
    #region EXCLUDE

    public override int GetHashCode()
    {
        static int GetHashCode(Angle angle) =>
            EqualityComparer<Angle>.Default.GetHashCode(angle);

        return (EqualityComparer<Type>.Default.GetHashCode(
            EqualityContract()) * -1521134295
            + GetHashCode(Longitude)) * -1521134295
            + GetHashCode(Latitude);
    }

    public override bool Equals(object? obj) =>
        Equals(obj as Coordinate);

    public virtual bool Equals(Coordinate? other) =>
        (object)this == other || (other is not null
            && EqualityContract() == other!.EqualityContract()
            && EqualityComparer<Angle>.Default.Equals(
                Longitude, other!.Longitude)
            && EqualityComparer<Angle>.Default.Equals(
                Latitude, other!.Latitude));

    public void Deconstruct(out Angle Longitude, out Angle Latitude)
    {
        Longitude = this.Longitude;
        Latitude = this.Latitude;
    }

    protected virtual Type EqualityContract() => typeof(Coordinate);

    public Type ExternalEqualityContract => EqualityContract();

    protected Coordinate(Coordinate original)
    {
        Longitude = original.Longitude;
        Latitude = original.Latitude;
    }
}

[CompilerGenerated]
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

    #endregion EXCLUDE
    public static bool operator !=(Angle left, Angle right) =>
        !(left == right);
    #endregion INCLUDE

    public static bool operator ==(Angle left, Angle right) =>
        left.Equals(right);

    public override int GetHashCode()
    {
        static int GetHashCode(int integer) =>
            EqualityComparer<int>.Default.GetHashCode(integer);

        return GetHashCode(Degrees) * -1521134295
            + GetHashCode(Minutes) * -1521134295
            + GetHashCode(Seconds) * -1521134295
            + EqualityComparer<string>.Default.GetHashCode(Name!);
    }

    public override bool Equals(object? obj) =>
        obj is Angle angle && Equals(angle);

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
