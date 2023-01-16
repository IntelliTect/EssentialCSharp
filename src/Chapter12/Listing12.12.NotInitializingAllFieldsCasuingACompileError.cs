namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_12;

using Listing12_08;
#region INCLUDE
public struct Pair<T> : IPair<T>
{
    // ERROR:  Field 'Pair<T>.Second' must be fully assigned
    //         before control leaves the constructor
    // public Pair(T first)
    // {  
    //     First = first;
    // }

    #region EXCLUDE
    public Pair(T first, T second)
    {
        First = first;
        Second = second;
    }

    public T First { get; set; }
    public T Second { get; set; }
    #endregion EXCLUDE
}
#endregion INCLUDE
