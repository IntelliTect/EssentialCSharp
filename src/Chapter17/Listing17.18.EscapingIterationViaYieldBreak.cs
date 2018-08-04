namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_18
{
    using System;
    using Listing17_10;
    using System.Collections.Generic;

    public struct Pair<T> : IPair<T>, IEnumerable<T>
    {
        #region Members
        public Pair(T first, T second)
        {
            First = first;
            Second = second;
        }
        public T First { get; }
        public T Second { get; }

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
        #endregion Members

        //Listing 17.18 Escaping Iteration via yield break
        public System.Collections.Generic.IEnumerable<T> GetNotNullEnumerator()
        {
            if((First == null) || (Second == null))
            {
                yield break;
            }
            yield return Second;
            yield return First;
        }

        //Listing 17.18 Escaping Iteration via yield break


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
