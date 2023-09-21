// Justification: Only showing partial implementation.
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_13;

using Listing12_08;
#region INCLUDE
public struct Pair<T> : IPair<T>
{
    public Pair(T first)
    {
        First = first;
        #region EXCLUDE
        // Justification: Ignore warning pending struct/class constraints, later on in the chapter, 
        //               so that Second can be declared as T?.
#pragma warning disable CS8601 // Possible null reference assignment.
        #endregion EXCLUDE
        #region HIGHLIGHT
        Second = default;
        #endregion HIGHLIGHT
        #region EXCLUDE
#pragma warning restore CS8601 // Possible null reference assignment.
        #endregion EXCLUDE
    }
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
