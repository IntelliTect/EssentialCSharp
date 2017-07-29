namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_43
{
    using Chapter07.Listing07_02;
    using Chapter07.Listing07_11;

    interface IReadOnlyPair<out T>
    {
        T First { get; }
        T Second { get; }
    }

    interface IPair<T>
    {
        T First { get; set; }
        T Second { get; set; }
    }

    public struct Pair<T> : IPair<T>, IReadOnlyPair<T>
    {
        public Pair(T first, T second)
        {
            _First = first;
            _ReadOnlyFirst = first;
            _Second = second;
            _ReadOnlySecond = second;
        }

        // ...

        T IPair<T>.First
        {
            get
            {
                return _First;
            }
            set
            {
                _First = value;
            }
        }
        private T _First;

        T IReadOnlyPair<T>.Second
        {
            get
            {
                return _ReadOnlySecond;
            }
        }
        private T _ReadOnlySecond;

        T IReadOnlyPair<T>.First
        {
            get
            {
                return _ReadOnlyFirst;
            }
        }
        private T _ReadOnlyFirst;

        T IPair<T>.Second
        {
            get
            {
                return _Second;
            }
            set
            {
                _Second = value;
            }
        }
        private T _Second;
    }

    class Program
    {
        static void Main()
        {
            // Allowed in C# 4.0
            Pair<Contact> contacts =
                new Pair<Contact>(
                    new Contact("Princess Buttercup"),
                    new Contact("Inigo Montoya"));
            IReadOnlyPair<PdaItem> pair = contacts;
            PdaItem pdaItem1 = pair.First;
            PdaItem pdaItem2 = pair.Second;
        }
    }
}