namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_09
{
    using Listing11_08;

    public struct Pair<T> : IPair<T>
    {
        public T First
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

        public T Second
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

}