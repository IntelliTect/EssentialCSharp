namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_16
{
    using System.Collections.Generic;
    using Listing17_14;

    public class BinaryTree<T> :
      IEnumerable<T>
    {
        public BinaryTree(T value)
        {
            Value = value;
        }

        #region IEnumerable<T>
        public IEnumerator<T> GetEnumerator()
        {
            // Return the item at this node
            yield return Value;

            // Iterate through each of the elements in the pair
            foreach(BinaryTree<T>? tree in SubItems)
            {
                if(tree != null)
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
        }
        #endregion IEnumerable<T>

        #region IEnumerable Members
        System.Collections.IEnumerator
            System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion

        public T Value { get; }  // C# 6.0 Getter-only Autoproperty

        public Pair<BinaryTree<T>> SubItems { get; set; }
    }
}
