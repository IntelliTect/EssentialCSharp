// Justification: Only showing partial implementaiton.
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable IDE0051 // Remove unused private members
#pragma warning disable IDE0044 // Add readonly modifier

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_46
{
    using System;

    public class Stack<T> where T : IComparable
    {
        private T[] _Items;

        public T[] Items { get => _Items; set => _Items = value; }

        // ...
    }
}