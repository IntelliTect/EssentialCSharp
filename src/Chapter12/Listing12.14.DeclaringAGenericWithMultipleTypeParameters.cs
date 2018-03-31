namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_14
{
    interface IPair<TFirst, TSecond>
    {
        TFirst First { get; set; }
        TSecond Second { get; set; }
    }

    public struct Pair<TFirst, TSecond> : IPair<TFirst, TSecond>
    {
        public Pair(TFirst first, TSecond second)
        {
            First = first;
            Second = second;
        }

        public TFirst First { get; set; }
        public TSecond Second { get; set; }

    }
}
