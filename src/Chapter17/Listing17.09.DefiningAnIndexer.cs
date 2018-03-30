namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_09
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

        public T First { get; }  // C# 6.0 Getter-Only Autoproperty

        public T Second { get; } // C# 6.0 Getter-Only Autoproperty

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
                            $"The enum { index.ToString() } has not been implemented");

                }
            }

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
        }
    }
}
