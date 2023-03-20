namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_11;

using Listing12_08;
#region INCLUDE
public struct Pair<T> : IPair<T>
{
    #region HIGHLIGHT
    public Pair(T first, T second)
    {
        First = first;
        Second = second;
    }
    #endregion HIGHLIGHT

    public T First { get; set; }
    public T Second { get; set; }
}
#endregion INCLUDE
