namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_10
{
    using System;

    // ----

    interface IPair<T>
    {
        T First { get; }

        T Second { get; }

        T this[PairItem index] { get; }
    }

    // ----

    public enum PairItem
    {
        First,
        Second
    }

    // ----

    public struct Pair<T> : IPair<T>
    {
        public Pair(T first, T second)
        {
            First = first;
            Second = second;
        }

        public T First { get; } // C# 6.0 Getter-Only Autoproperty

        public T Second { get; } // C# 6.0 Getter-Only Autoproperty

        [System.Runtime.CompilerServices.IndexerName("Entry")]
        public T this[PairItem index]
        {
            get
            {
                switch(index)
                {
                    case PairItem.First:
                        return First;
                    case PairItem.Second:
                        return Second;
                    default:
                        throw new NotImplementedException(
                            string.Format(
                            "The enum {0} has not been implemented",
                            index.ToString()));
                }
            }
        }
    }
}
