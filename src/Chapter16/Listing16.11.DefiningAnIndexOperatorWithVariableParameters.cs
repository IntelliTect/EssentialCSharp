using AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_10;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_11
{
    using System;

    public class BinaryTree<T> 
    {

        public BinaryTree(T value)
        {
            Value = value;
        }

        /// <summary>
        /// Returns the BinaryTree<typeparamref name="T"/> at a particular location.
        /// </summary>
        /// <param name="branches">An array of PairItems 
        /// pointing to a particular branch.</param>
        /// <example>
        /// familyTree.SubItems.Second.SubItems[PairItem.First].Value
        /// </example>
        public BinaryTree<T> this[params PairItem[] branches]
        {
            get
            {
                BinaryTree<T> currentNode = this;

                // Allow either an empty array or null
                // to refer to the root node.
                int totalLevels = branches?.Length ?? 0;
                int currentLevel = 0;

                while (currentLevel < totalLevels)
                {
                    System.Diagnostics.Debug.Assert(branches != null,
                        $"{ nameof(branches) } != null");

                    currentNode = currentNode.SubItems[
                        branches[currentLevel]];
                    if (currentNode == null)
                    {
                        // The binary tree at this location is null.
                        throw new IndexOutOfRangeException();
                    }
                    currentLevel++;
                }
                return currentNode;
            }
        }

        public T Value { get; set; }

        public Pair<BinaryTree<T>> SubItems {get;set;}

    }

    public class Program
    {
        public static void Main()
        {
            // JFK
            var jfkFamilyTree = new BinaryTree<string>(
                "John Fitzgerald Kennedy");

            jfkFamilyTree.SubItems = new Pair<BinaryTree<string>>(
                new BinaryTree<string>("Joseph Patrick Kennedy"),
                new BinaryTree<string>("Rose Elizabeth Fitzgerald"));

            // Grandparents (Father's side)
            jfkFamilyTree.SubItems.First.SubItems =
                new Pair<BinaryTree<string>>(
                new BinaryTree<string>("Patrick Joseph Kennedy"),
                new BinaryTree<string>("Mary Augusta Hickey"));

            // Grandparents (Mother's side)
            jfkFamilyTree.SubItems.Second.SubItems =
                new Pair<BinaryTree<string>>(
                new BinaryTree<string>("John Francis Fitzgerald"),
                new BinaryTree<string>("Mary Josephine Hannon"));

            Console.WriteLine(jfkFamilyTree[PairItem.Second, PairItem.First].Value);
            Console.WriteLine(jfkFamilyTree[PairItem.Second, PairItem.Second].Value);
        }
    }
}
