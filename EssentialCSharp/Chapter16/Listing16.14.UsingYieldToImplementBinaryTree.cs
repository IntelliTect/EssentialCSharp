namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_14
{
    using System;
    using Listing16_10;

    using System.Collections.Generic;

    public struct Pair<T> : IPair<T>,
    IEnumerable<T>
    {
        public Pair(T first, T second) : this()
        {
            First = first;
            Second = second;
        }
        public T First { get; private set; }
        public T Second { get; private set; }

        #region Indexer
        public T this[PairItem index]
        {
            get
            {
                switch (index)
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
            set
            {
                switch (index)
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
        #endregion Indexer
        }

        #region IEnumerable<T>
        public IEnumerator<T> GetEnumerator()
        {
            yield return First;
            yield return Second;
        }
        #endregion IEnumerable<T>

        #region IEnumerable Members
        System.Collections.IEnumerator
            System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }
}