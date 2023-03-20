namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_09;

using Listing12_08;
#region INCLUDE
public struct Pair<T> : IPair<T>
{
    public T First { get; set; }
    public T Second { get; set; }
}
#endregion INCLUDE
