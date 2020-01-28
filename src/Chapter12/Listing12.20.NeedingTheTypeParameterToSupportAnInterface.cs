namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_20
{
    using System;
    using Listing12_13;
// In an actual implementation Item would be used to hold some value
#pragma warning disable CS0168

    public class BinaryTree<T>
    {
        public BinaryTree(T item)
        {
            Item = item;
        }

        public T Item { get; set; }

        public Pair<BinaryTree<T>> SubItems
        {
            get { return _SubItems; }
            set
            {
                IComparable<T> first;
                // ERROR: Cannot implicitly convert type...
                //first = value.First;  // Explicit cast required

                //if(first.CompareTo(value.Second) < 0)
                //{
                //    // first is less than second
                //    //...
                //}
                //else
                //{
                //    // first and second are the same or
                //    // second is less than first
                //    //...
                //}
                _SubItems = value;
            }
        }
        private Pair<BinaryTree<T>> _SubItems;
    }
#pragma warning restore CS0168
}
