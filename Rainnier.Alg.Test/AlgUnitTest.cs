using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rainnier.Alg;
using Rainnier.Alg.arr;
using Rainnier.Alg.leetcode;
using Rainnier.Alg.str;

namespace Rainnier.Alg.Test
{
    [TestClass]
    public class AlgUnitTest
    {
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

        [TestMethod]
        public void Leetcode6()
        {
            var leetcode6 = new Leetcode6();
            Assert.AreEqual("LCIRETOESIIGEDHN", leetcode6.Convert("LEETCODEISHIRING",3));
            Assert.AreEqual("LDREOEIIECIHNTSG", leetcode6.Convert("LEETCODEISHIRING", 4));
            Assert.AreEqual("", leetcode6.Convert("", 3));
            Assert.AreEqual("a", leetcode6.Convert("a", 3));
            Assert.AreEqual("AB", leetcode6.Convert("AB", 1));
            Assert.AreEqual("ACBD", leetcode6.Convert("ABCD", 2));
        }

        [TestMethod]
        public void KMPPartialTable()
        {
            var kmp = new KMP();
            var result = kmp.getPartialMatchArray("ABCDABD");
            
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(0, result[1]);
            Assert.AreEqual(0, result[2]);
            Assert.AreEqual(0, result[3]);
            Assert.AreEqual(1, result[4]);
            Assert.AreEqual(2, result[5]);
            Assert.AreEqual(0, result[6]);
            
        }

        [TestMethod]
        public void KMPTest()
        {
            var kmp = new KMP();
            var result = kmp.IsSubString("BBC ABCDAB ABCDABCDABDE", "ABCDABD");

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void LeetCode1439()
        {
            var lc1439 = new Leetcode1439();
            int[][] mat = new int[2][];
            mat[0] = new int[3] { 1, 3, 11 };
            mat[1] = new int[3] { 2, 4, 6 };

            var rr = lc1439.KthSmallest(mat, 5);

            Assert.Equals(7, rr);
        }

        [TestMethod]
        //[["1","1","1","1","0"],["1","1","0","1","0"],["1","1","0","0","0"],["0","0","0","0","0"]]
        //[["1","1","0","0","0"],["1","1","0","0","0"],["0","0","1","0","0"],["0","0","0","1","1"]]
        public void LeetCode200()
        {
            var lc200 = new Leetcode200();
            char[][] mat = new char[4][];
            mat[0] = new char[5] { '1', '1', '0', '0', '0' };
            mat[1] = new char[5] { '1', '1', '0', '0', '0' };
            mat[2] = new char[5] { '0', '0', '1', '0', '0' };
            mat[3] = new char[5] { '0', '0', '0', '1', '1' };

            var rr = lc200.NumIslands(mat);

            Assert.Equals(3, rr);
        }

        [TestMethod]
        //[["1","1","1","1","0"],["1","1","0","1","0"],["1","1","0","0","0"],["0","0","0","0","0"]]
        //[["1","1","0","0","0"],["1","1","0","0","0"],["0","0","1","0","0"],["0","0","0","1","1"]]
        //[["1","1","1"],["1","0","1"],["1","1","1"]]
        public void LeetCode200L2()
        {
            var lc200 = new Leetcode200();
            char[][] mat = new char[3][];
            mat[0] = new char[3] { '1', '1', '1' };
            mat[1] = new char[3] { '1', '0', '1' };
            mat[2] = new char[3] {  '1', '1', '1' };
          

            var rr = lc200.NumIslands(mat);

            Assert.Equals(3, rr);
        }

        [TestMethod]
        //[["1","1","1","1","0"],["1","1","0","1","0"],["1","1","0","0","0"],["0","0","0","0","0"]]
        //[["1","1","0","0","0"],["1","1","0","0","0"],["0","0","1","0","0"],["0","0","0","1","1"]]
        //[["1","1","1"],["1","0","1"],["1","1","1"]]
        public void LeetCode164()
        {
            var lc164 = new Leetcode164();
            int[] input = new int[2] { 1, 10000000 };
            

            var rr = lc164.MaximumGap(input);

        }
    }
}
