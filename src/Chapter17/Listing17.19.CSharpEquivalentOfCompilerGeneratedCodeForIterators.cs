using System.Collections;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_19
{
    using Listing17_10;
    using System;
    using System.Collections.Generic;
// Not concerned about Type naming for compiler simulated code
#pragma warning disable CS0693

    public class Pair<T> : IPair<T>, IEnumerable<T>
    {
        // ...

        // The iterator is expanded into the following
        // code by the compiler

        public virtual IEnumerator<T> GetEnumerator()
        {
            __ListEnumerator<T> result = new __ListEnumerator<T>(0);
            result._Pair = this;
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T First { get; private set; }
        public T Second { get; private set; }

        #region Indexer
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
        #endregion Indexer
        
        private sealed class __ListEnumerator<T> : IEnumerator<T>
        {
            public __ListEnumerator(int itemCount)
            {
                _ItemCount = itemCount;
            }

            public Pair<T> _Pair;
            T _Current;
            int _ItemCount;

            public void Reset()
            {
                throw new NotImplementedException();
            }

            T IEnumerator<T>.Current
            {
                get { throw new NotImplementedException(); }
            }

            public object Current
            {
                get
                {
                    return _Current;
                }
            }

            public bool MoveNext()
            {
                switch(_ItemCount)
                {
                    case 0:
                        _Current = _Pair.First;
                        _ItemCount++;
                        return true;
                    case 1:
                        _Current = _Pair.Second;
                        _ItemCount++;
                        return true;
                    default:
                        return false;
                }
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }
    }
#pragma warning restore CS0693
}
