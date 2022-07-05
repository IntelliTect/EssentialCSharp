﻿using AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_13;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_21.Tests
{
    [TestClass]
    public class BinaryTree
    {
        [TestMethod]
        public void Create_BinaryTree_Success()
        {
            _ = new BinaryTree<string?>(null)
            {
                SubItems = new Pair<BinaryTree<string?>?>(
                new BinaryTree<string?>("b"),
                new BinaryTree<string?>("a"))
            };
        }

        [TestMethod]
        public void Create_BinaryTreeWithNullSubItems_Success()
        {
            _ = new BinaryTree<string?>(null)
            {
                SubItems = new Pair<BinaryTree<string?>?>(
               null, null)
            };
        }


    }
}
