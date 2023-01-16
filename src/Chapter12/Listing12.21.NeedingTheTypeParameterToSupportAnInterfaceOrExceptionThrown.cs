namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_21;

using System;
using Listing12_13;
#region INCLUDE
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
                // Null handling removed for elucidation

                // Using C# 8.0 Pattern Matching. Switch to
                // checking for null prior to C# 8.0
                #region EXCLUDE
                case { First: null}:
                    // First is null
                    break;
                case { Second: null }:
                    // Second is null
                    break;
                #endregion EXCLUDE
                case
                {
                        #region HIGHLIGHT
                        First: {Item: IComparable<T> first },
                        #endregion HIGHLIGHT
                        Second: {Item: T second } }:
                    #region HIGHLIGHT
                    if (first.CompareTo(second) < 0)
                    #endregion HIGHLIGHT
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
#endregion INCLUDE
