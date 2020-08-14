using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rainnier.Alg;
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
    }
}
