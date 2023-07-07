using System;
using System.Collections.Generic;
using System.Management.Instrumentation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rainnier.Alg;
using Rainnier.Alg.arr;
using Rainnier.Alg.leetcode.LCP;
using Rainnier.Alg.str;
using Rainnier.Alg.tree;
using Rainnier.Alg.tree.model;


namespace Rainnier.Alg.Test.tree
{
    [TestClass]
    public class TreeTests
    {
        [TestMethod]
        public void NodeSerach()
        {
            TreeNode root;

            TreeNode searchNode;
            var c = new NodeSearch();
            root = new TreeNode(10);
            var node1 = root.left = new TreeNode(5);
            root.right = new TreeNode(14);
            node1.left = new TreeNode(1);
            var node4 = node1.right = new TreeNode(8);
            node4.left = new TreeNode(6);
            searchNode = node4.right = new TreeNode(9);

            var stack = new Stack<TreeNode>();
            c.NodeSearchMethod(root, stack, searchNode);

            Assert.AreEqual(4, stack.Count);
        }
    }
}
