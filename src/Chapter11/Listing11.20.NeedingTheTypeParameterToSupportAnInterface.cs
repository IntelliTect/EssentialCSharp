namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_20
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
                // ERROR: Cannot implicitly convert type...
                //first = value.First;  // Explicit cast required

                //if(first.CompareTo(value.Second) < 0)
                //{
                //    // first is less than second.
                //    //...
                //}
                //else
                //{
                //    // first and second are the same or
                //    // second is less than first.
                //    //...
                //}
                _SubItems = value;
            }
        }
        private Pair<BinaryTree<T>> _SubItems;
    }
}