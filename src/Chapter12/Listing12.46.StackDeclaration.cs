// Justification: Only showing partial implementaiton.
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_46
{
    using System;

    public class Stack<T> where T : IComparable
    {
        T[] items;

        // ...
    }
}