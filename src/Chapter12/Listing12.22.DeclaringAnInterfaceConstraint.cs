namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_22
{
    using System;
    using Listing12_13;

    public class BinaryTree<T>
        where T : System.IComparable<T>
    {
        public T Item { get; set; }

        public Pair<BinaryTree<T>> SubItems
        {
            get { return _SubItems; }
            set
            {
                IComparable<T> first;
                // Notice that the cast can now be eliminated
                first = value.First.Item;

                if(first.CompareTo(value.Second.Item) < 0)
                {
                    // first is less than second
                    //...
                }
                else
                {
                    // second is less than or equal to first
                    //...
                }
                _SubItems = value;
            }
        }
        private Pair<BinaryTree<T>> _SubItems;

    }
}
