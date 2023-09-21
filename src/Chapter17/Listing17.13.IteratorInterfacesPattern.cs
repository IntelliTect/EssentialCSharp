namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_13;

#region INCLUDE
using System.Collections;
using System.Collections.Generic;

public class BinaryTree<T> :
#region HIGHLIGHT
IEnumerable<T>
#endregion HIGHLIGHT
{
    public BinaryTree(T value)
    {
        Value = value;
    }

    #region IEnumerable<T>
    #region HIGHLIGHT
    public IEnumerator<T> GetEnumerator()
    #endregion HIGHLIGHT
    {
        #region EXCLUDE
        return new List<T>.Enumerator(); // This will be implemented in 16.16
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator(); // This will be implemented in 16.16
        #endregion EXCLUDE
    }
    #endregion IEnumerable<T>

    public T Value { get; }
    public Pair<BinaryTree<T>> SubItems { get; set; }
}

public struct Pair<T>
{
    public Pair(T first, T second) : this()
    {
        First = first;
        Second = second;
    }
    public T First { get; }
    public T Second { get; }
}
#endregion INCLUDE
