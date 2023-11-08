namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_17;

using System.Collections.Generic;
using Listing17_15;
#region INCLUDE
public class BinaryTree<T> :
  IEnumerable<T>
{
    #region EXCLUDE
    public BinaryTree(T value)
    {
        Value = value;
    }
    #endregion EXCLUDE
    #region IEnumerable<T>
    public IEnumerator<T> GetEnumerator()
    {
        // Return the item at this node
        yield return Value;

        // Iterate through each of the elements in the pair
        #region HIGHLIGHT
        foreach (BinaryTree<T>? tree in SubItems)
        {
            if(tree is not null)
            {
                // Since each element in the pair is a tree,
                // traverse the tree and yield each
                // element
                foreach(T item in tree)
                {
                    yield return item;
                }
            }
        }
        #endregion HIGHLIGHT
    }
    #endregion IEnumerable<T>

    #region IEnumerable Members
    System.Collections.IEnumerator
        System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    #endregion
    #region EXCLUDE
    public T Value { get; }  // C# 6.0 Getter-only AutoProperty

    public Pair<BinaryTree<T>> SubItems { get; set; }
    #endregion EXCLUDE
}
#endregion INCLUDE
