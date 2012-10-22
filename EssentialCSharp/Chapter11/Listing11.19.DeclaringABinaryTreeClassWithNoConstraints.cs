namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_19
{
    using Listing11_13;

    public class BinaryTree<T>
    {
        public BinaryTree(T item)
        {
            Item = item;
        }

        public T Item
        {
            get { return _Item; }
            set { _Item = value; }
        }
        private T _Item;

        public Pair<BinaryTree<T>> SubItems
        {
            get { return _SubItems; }
            set { _SubItems = value; }
        }
        private Pair<BinaryTree<T>> _SubItems;
    }
}