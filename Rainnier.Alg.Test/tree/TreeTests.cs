using System;
using System.Collections.Generic;
using System.Management.Instrumentation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rainnier.Alg;
using Rainnier.Alg.arr;
using Rainnier.Alg.leetcode.LCP;
using Rainnier.Alg.str;
using Rainnier.Alg.tree.model;


namespace Rainnier.Alg.Test.tree
{
    [TestClass]
    internal class TreeTests
    {
        private TreeNode root;

        [TestMethod]
        public void Leetcode214()
        {
            var leetcode214 = new Leetcode214();
            Assert.AreEqual(leetcode214.ShortestPalindrome("abc"), "cbabc");
            Assert.AreEqual(leetcode214.ShortestPalindrome("abba"), "abba");
            Assert.AreEqual(leetcode214.ShortestPalindrome("aacecaaa"), "aaacecaaa");
            Assert.AreEqual(leetcode214.ShortestPalindrome(""), "");
            Assert.AreEqual(leetcode214.ShortestPalindrome("a"), "a");
        }
    }
}
