namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_21
{
    using System;
    using Listing12_13;

    public class BinaryTree<T>
    {
        public BinaryTree(T item)
        {
            Item = item;
        }

        public T Item { get; set; }
        public Pair<BinaryTree<T>?>? SubItems
        {
            get { return _SubItems; }
            set
            {
                switch (value)
                {
                    case { First: null}:
                        // First is null
                        break;
                    case { Second: null }:
                        // Second is null
                        break;
                    case { 
                            First: {Item: IComparable<T> first }, 
                            Second: {Item: T second } }:
                        if(first.CompareTo(second) < 0)
                        {
                            // first is less than second
                        }
                        else
                        {
                            // second is less than or equal to first
                        }
                        break;
                    default:
                        throw new InvalidCastException(
                            @$"Unable to sort the items as { 
                                typeof(T) } does not support IComparable<T>.");
                };
                _SubItems = value;
            }
        }
    private Pair<BinaryTree<T>?>? _SubItems;
    }
}
