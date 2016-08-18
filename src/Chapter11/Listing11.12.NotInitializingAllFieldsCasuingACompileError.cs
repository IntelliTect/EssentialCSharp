namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_12
{
    using Listing11_08;

    public struct Pair<T> : IPair<T>
    {
        // ERROR:  Field 'Pair<T>._second' must be fully assigned
        //         before control leaves the constructor
        // public Pair(T first)
        // {  
        //     First = first;
        // }

        public Pair(T first, T second)
        {
            First = first;
            Second = second;
        }

        public T First { get; set; }
        public T Second { get; set; }

    }
}