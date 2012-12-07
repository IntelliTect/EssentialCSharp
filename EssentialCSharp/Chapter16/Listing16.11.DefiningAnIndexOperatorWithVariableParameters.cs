using System.Collections;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_10;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_11
{
    using System;
    using System.Collections.Generic;

    public class BinaryTree<T> :
        IEnumerable<T>
    {

        // ...
        public T this[params PairItem[] branches]
        {
            get
            {
                BinaryTree<T> currentNode = this;
                int totalLevels =
                    (branches == null) ? 0 : branches.Length;
                int currentLevel = 0;

                while(currentLevel < totalLevels)
                {
                    currentNode = currentNode.SubItems[
                        branches[currentLevel]];
                    if(currentNode == null)
                    {
                        // The binary tree at this location is null.
                        throw new IndexOutOfRangeException();
                    }
                    currentLevel++;
                }

                return currentNode.Value;
            }
            set
            {
                // ...
            }
        }

        public T Value
        {
            get { return _Value; }
            set { _Value = value; }
        }
        private T _Value;

        public Pair<BinaryTree<T>> SubItems
        {
            get { return _SubItems; }
            set { _SubItems = value; }
        }
        private Pair<BinaryTree<T>> _SubItems;

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
