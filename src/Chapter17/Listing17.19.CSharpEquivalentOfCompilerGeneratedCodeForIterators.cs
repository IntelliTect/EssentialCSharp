using AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_10;
using System;
using System.Collections;
using System.Collections.Generic;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_19
{
    [NullableContext(1)]
    [Nullable(0)]
    public struct Pair<[Nullable(2)] T> : IPair<T>, IEnumerable<T>, IEnumerable
    {
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
                PairItem pairItem = index;
                PairItem pairItem2 = pairItem;
                T result;
                if (pairItem2 != PairItem.First)
                {
                    if (pairItem2 != PairItem.Second)
                    {
                        throw new NotImplementedException(string.Format("The enum {0} has not been implemented", index.ToString()));
                    }
                    result = Second;
                }
                else
                {
                    result = First;
                }
                return result;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            yield return First;
            yield return Second;
            yield break;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
