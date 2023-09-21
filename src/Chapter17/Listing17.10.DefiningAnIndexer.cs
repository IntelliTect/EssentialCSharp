namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_10;

using System;

// ----
#region INCLUDE
interface IPair<T>
{
    T First { get; }
    T Second { get; }
    #region HIGHLIGHT
    T this[PairItem index] { get; }
    #endregion HIGHLIGHT
}

public enum PairItem
{
    First,
    Second
}

public struct Pair<T> : IPair<T>
{
    public Pair(T first, T second)
    {
        First = first;
        Second = second;
    }

    public T First { get; }
    public T Second { get; }

    #region HIGHLIGHT
    public T this[PairItem index]
    {
        get
        {
            #endregion HIGHLIGHT
            switch (index)
            {
                case PairItem.First:
                    return First;
                case PairItem.Second:
                    return Second;
                default:
                    throw new NotImplementedException(
                        $"The enum { index.ToString() } has not been implemented");

            }
        }
        #region EXCLUDE

        /*  
        // In keeping with the principal that structs should
        // be read-only, the setter is commented out

        set
        {
            switch(index)
            {
                case PairItem.First:
                    First = value;
                    break;
                case PairItem.Second:
                    Second = value;
                    break;
                default:
                    throw new NotImplementedException(
                        string.Format(
                        "The enum {0} has not been implemented",
                        index.ToString()));
            }
        }
        */
        #endregion EXCLUDE
        #region HIGHLIGHT
    }
    #endregion HIGHLIGHT
}
#endregion INCLUDE
