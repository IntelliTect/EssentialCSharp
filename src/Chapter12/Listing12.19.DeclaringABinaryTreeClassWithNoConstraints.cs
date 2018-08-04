namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_19
{
    using Listing12_13;

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
