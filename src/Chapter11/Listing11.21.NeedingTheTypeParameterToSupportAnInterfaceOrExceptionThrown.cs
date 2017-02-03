namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_21
{
    using System;
    using Listing11_13;

    public class BinaryTree<T>
    {
        public T Item { get; set; }
        public Pair<BinaryTree<T>> SubItems
        {
            get { return _SubItems; }
            set
            {
                IComparable<T> first;
                first = (IComparable<T>)value.First.Item;

                if(first.CompareTo(value.Second.Item) < 0)
                {
                    // first is less than second.
                    // ...
                }
                else
                {
                    // second is less than or equal to first.
                    // ...
                }
                _SubItems = value;
            }
        }
        private Pair<BinaryTree<T>> _SubItems;
    }
}