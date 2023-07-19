namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_02;

#region INCLUDE
// Use the record struct construct to declare a value type
public readonly record struct Angle(
    int Degrees, int Minutes, int Seconds, string? Name = null);
#endregion INCLUDE
