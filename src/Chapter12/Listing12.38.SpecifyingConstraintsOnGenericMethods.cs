namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_38
{
    using System;
    using Listing12_22;

    public class ConsoleTreeControl
    {
        // Generic method Show<T>
        public static void Show<T>(BinaryTree<T> tree, int indent)
            where T : IComparable<T>
        {
            Console.WriteLine("\n{0}{1}",
                "+ --".PadLeft(5 * indent, ' '),
                tree.Item.ToString());
            if(tree.SubItems.First != null)
                Show(tree.SubItems.First, indent + 1);
            if(tree.SubItems.Second != null)
                Show(tree.SubItems.Second, indent + 1);
        }
    }
}
