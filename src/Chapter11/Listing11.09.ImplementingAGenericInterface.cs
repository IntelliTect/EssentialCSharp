namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_09
{
    using Listing11_08;

    public struct Pair<T> : IPair<T>
    {
        public T First { get; set; }
        public T Second { get; set; }
    }

}