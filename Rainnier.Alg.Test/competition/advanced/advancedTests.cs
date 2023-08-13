using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rainnier.Alg.competition.advanced;
using System;

namespace Rainnier.Alg.Test.competition.advanced
{
    [TestClass]
    public class advancedTests
    {
        [TestMethod]
        public void BinaryIndexedTree()
        {
            var array = new int[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            var tree = new BinaryIndexedTree(array);

            tree.InitializeBinaryIndexedTree();

            int result1 = tree.getSum(1);
            int result2 = tree.getSum(2);
            int result9 = tree.getSum(9);

            var span = tree.GetWindowSum(3, 6);

            Assert.AreEqual(9, result1);
            Assert.AreEqual(15, result2);
            Assert.AreEqual(85, result9);
            Assert.AreEqual(34, span);
        }

        [TestMethod]
        public void TestSegmentTree()
        {
            var array = new int[] { 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            var tree = new SegmentTree(array);

            tree.Initialize(1, 1, 10);

            Assert.AreEqual(1, 1);

        }
    }
}
