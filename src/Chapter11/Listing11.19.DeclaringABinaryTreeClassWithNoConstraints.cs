namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_19
{
    using Listing11_13;

    public class BinaryTree<T>
    {
        public BinaryTree(T item)
        {
            Item = item;
        }

        public T Item { get; set; }
        public Pair<BinaryTree<T>> SubItems { get; set; }
    }
}