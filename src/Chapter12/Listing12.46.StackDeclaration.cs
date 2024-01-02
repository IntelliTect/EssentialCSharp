// Justification: Only showing partial implementation.
#pragma warning disable CS8618 // 不可为空的字段未初始化。考虑声明为可空。

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
