// Justification: Only showing partial implementaiton.
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_13
{
    using Listing12_08;

    public struct Pair<T> : IPair<T>
    {
        public Pair(T first)
        {
            First = first;
// Justifiction: Ignore warning pending struct/class constraints, later on in the chapter, 
//               so that Second can be declared as T?.
#pragma warning disable CS8601 // Possible null reference assignment.
            Second = default;
#pragma warning restore CS8601 // Possible null reference assignment.
        }

        public Pair(T first, T second)
        {
            First = first;
            Second = second;
        }

        public T First { get; set; }
        public T Second { get; set; }
    }
}
