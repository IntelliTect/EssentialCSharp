using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_02;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_06;

#region INCLUDE
using System.Runtime.CompilerServices;
using System.Text;

[CompilerGenerated]
public class Coordinate : IEquatable<Coordinate>
{

    public Angle Longitude { get; init; }
    public Angle Latitude { get; init; }

    public Coordinate(Angle Longitude, Angle Latitude) : base()
    {
        this.Longitude = Longitude;
        this.Latitude = Latitude;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new ();
        stringBuilder.Append("Coordinate");
        stringBuilder.Append(" { ");
        if (PrintMembers(stringBuilder))
        {
            stringBuilder.Append(' ');
        }
        stringBuilder.Append('}');
        return stringBuilder.ToString();
    }    

    protected virtual bool PrintMembers(StringBuilder builder)
    {
        RuntimeHelpers.EnsureSufficientExecutionStack();
        builder.Append("Longitude = ");
        builder.Append(Longitude.ToString());
        builder.Append(", Latitude = ");
        builder.Append(Latitude.ToString());
        return true;
    }

    public static bool operator !=(
        Coordinate? left, Coordinate? right) =>
            !(left == right);

    public static bool operator ==(
        Coordinate? left, Coordinate? right) =>
            ReferenceEquals(left, right) ||
                (left?.Equals(right) ?? false);

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

    public void Deconstruct(
        out Angle Longitude, out Angle Latitude)
    {
        Longitude = this.Longitude;
        Latitude = this.Latitude;
    }

    protected virtual Type EqualityContract() => typeof(Coordinate);

    public Type ExternalEqualityContract => EqualityContract();

    // Actual name in IL is "<Clone>$". However, 
    // you can't add a Clone method to a record.
    public Coordinate Clone() => new(this);

    protected Coordinate(Coordinate original)
    {
        Longitude = original.Longitude;
        Latitude = original.Latitude;
    }
}
#endregion INCLUDE
