namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_17
{
    using System;
    using Listing17_14;
    using Listing17_16;

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

            foreach (string name in jfkFamilyTree)
            {
                Console.WriteLine(name);
            }
        }
    }
}