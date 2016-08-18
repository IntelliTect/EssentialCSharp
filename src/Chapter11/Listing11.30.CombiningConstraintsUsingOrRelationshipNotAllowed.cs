namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_30
{
    public class BinaryTree<T>
        // Error: OR is not supported.
        //where T: System.IComparable<T> || System.IFormattable
    {
        // ...
    }
}