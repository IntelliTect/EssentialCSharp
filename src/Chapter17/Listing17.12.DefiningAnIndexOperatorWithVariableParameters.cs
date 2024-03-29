using AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_10;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_12;

#region INCLUDE
using System;

public class BinaryTree<T> 
{
    #region EXCLUDE
    public BinaryTree(T value)
    {
        Value = value;
    }

    /// <summary>
    /// Returns the BinaryTree<typeparamref name="T"/> at a particular location
    /// </summary>
    /// <param name="branches">An array of PairItems 
    /// pointing to a particular branch.</param>
    /// <example>
    /// familyTree.SubItems.Second.SubItems[PairItem.First].Value
    /// </example>
    #endregion EXCLUDE
    public BinaryTree<T> this[params PairItem[]? branches]
    {
        get
        {
            BinaryTree<T> currentNode = this;

            // Allow either an empty array or null
            // to refer to the root node
            int totalLevels = branches?.Length ?? 0;
            int currentLevel = 0;

            while (currentLevel < totalLevels)
            {
                System.Diagnostics.Debug.Assert(branches is not null,
                    $"{ nameof(branches) } is not null");

                currentNode = currentNode.SubItems[
                    branches[currentLevel]];
                if (currentNode is null)
                {
                    // The binary tree at this location is null
                    throw new IndexOutOfRangeException();
                }
                currentLevel++;
            }
            return currentNode;
        }
    }
    #region EXCLUDE

    public T Value { get; set; }

    public Pair<BinaryTree<T>> SubItems {get;set;}
    #endregion EXCLUDE
}
#endregion INCLUDE

public class Program
{
    public static void Main()
    {
        // JFK
        var jfkFamilyTree = new BinaryTree<string>(
            "John Fitzgerald Kennedy")
        {
            SubItems = new Pair<BinaryTree<string>>(
                new BinaryTree<string>("Joseph Patrick Kennedy")
                {
                    // Grandparents (Father's side)
                    SubItems = new Pair<BinaryTree<string>>(
                        new BinaryTree<string>("Patrick Joseph Kennedy"),
                        new BinaryTree<string>("Mary Augusta Hickey"))
                },
                new BinaryTree<string>("Rose Elizabeth Fitzgerald")
                { 
                    // Grandparents (Mother's side)
                    SubItems = new Pair<BinaryTree<string>>(
                        new BinaryTree<string>("John Francis Fitzgerald"),
                        new BinaryTree<string>("Mary Josephine Hannon"))
                })
        };

        Console.WriteLine(jfkFamilyTree[PairItem.Second, PairItem.First].Value);
        Console.WriteLine(jfkFamilyTree[PairItem.Second, PairItem.Second].Value);
    }
}
