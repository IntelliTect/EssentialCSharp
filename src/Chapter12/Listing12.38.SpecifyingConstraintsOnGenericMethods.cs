namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_38;

using System;
using Listing12_22;

#region INCLUDE
public class ConsoleTreeControl
{
    // Generic method Show<T>
    public static void Show<T>(BinaryTree<T> tree, int indent)
        #region HIGHLIGHT
        where T : IComparable<T>
        #endregion HIGHLIGHT
    {
        Console.WriteLine("\n{0}{1}",
            "+ --".PadLeft(5 * indent, ' '),
            tree.Item.ToString());
        if(tree.SubItems.First is not null)
            Show(tree.SubItems.First, indent + 1);
        if(tree.SubItems.Second is not null)
            Show(tree.SubItems.Second, indent + 1);
    }
}
#endregion INCLUDE
