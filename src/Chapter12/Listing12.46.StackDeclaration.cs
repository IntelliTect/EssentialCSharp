// Justification: Only showing partial implementation.
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_46;

using System;
#region INCLUDE
public class Stack<T> where T : IComparable
{
    private T[] _Items;
    // rest of the class here
    #region EXCLUDE
    public T[] Items { get => _Items; set => _Items = value; }
    #endregion EXCLUDE
}
#endregion INCLUDE
