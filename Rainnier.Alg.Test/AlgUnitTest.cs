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
            var lc200 = new IslandNumber();
            char[][] mat = new char[3][];
            mat[0] = new char[3] { '1', '1', '1' };
            mat[1] = new char[3] { '1', '0', '1' };
            mat[2] = new char[3] {  '1', '1', '1' };
          

            var rr = lc200.NumIslands(mat);

            Assert.AreEqual(1, rr);
        }

        [TestMethod]
        public void LeetCode164()
        {
            var lc164 = new Leetcode164();
            int[] input = new int[2] { 1, 10000000 };
            

            var rr = lc164.MaximumGap(input);

        }

        [TestMethod]
        public void IslandNumber()
        {
            var lc200 = new IslandNumber();
            char[][] mat = new char[4][];
            mat[0] = new char[5] { '1', '1', '0', '0', '0' };
            mat[1] = new char[5] { '1', '1', '0', '0', '0' };
            mat[2] = new char[5] { '0', '0', '1', '0', '0' };
            mat[3] = new char[5] { '0', '0', '0', '1', '1' };

            var rr = lc200.NumIslands(mat);

            Assert.AreEqual(3, rr);
        }

        [TestMethod]
        public void leetCode445Test()
        {
            var lc200 = new Leetcode455();
            char[][] mat = new char[4][];
            var g = new int[3] { 1, 2, 3 };
            var s = new int[2] { 1, 1 };

            var rr = lc200.FindContentChildren(g,s);

            Assert.AreEqual(1, rr);
        }

        [TestMethod]
        public void JumpStepTest()
        {
            var lc200 = new Leetcode55();

            var g = new int[5] { 2,3,1,1,4 };


            var rr = lc200.JumpStep(g);

            Assert.AreEqual(2, rr);
        }

        [TestMethod]
        public void OverlapSpeaceTest()
        {
            var lc200 = new Leetcode435();

            var input = new int[4][];
            input[0] = new int[2] { 1, 2 };
            input[1] = new int[2] { 2,3 };
            input[2] = new int[2] { 3,4 };
            input[3] = new int[2] { 1, 3 };


            var rr = lc200.EraseOverlapIntervals(input);

            Assert.AreEqual(2, rr);
        }


        [TestMethod]
        public void LeetCode823Test()
        {
            var lc200 = new Leetcode823();

            var input = new int[4] { 2,4,5,10};


            var rr = lc200.NumFactoredBinaryTrees(input);

            Assert.AreEqual(7, rr);
        }


        [TestMethod]
        public void LeetCode17Test()
        {
            var lc200 = new Leetcode17();

           var rr = lc200.LetterCombinations_2("23");

            Assert.AreEqual(9, rr.Count);
        }

        [TestMethod]
        public void LeetCode39Test()
        {
            var lc200 = new Leetcode39();

            var rr = lc200.CombinationSum_2(new int[3] { 2,3,5}, 8);

            Assert.AreEqual(3, rr.Count);
        }


        [TestMethod]
        public void LeetCode46Test()
        {
            var lc200 = new Leetcode46();

            var rr = lc200.Permute(new int[3] { 1, 2, 3 });

            Assert.AreEqual(6, rr.Count);
        }

        [TestMethod]
        public void LeetCode46Test_2()
        {
            var lc200 = new Leetcode46();

            var rr = lc200.Permute_2(new int[3] { 1, 2, 3 });

            Assert.AreEqual(6, rr.Count);
        }

        [TestMethod]
        public void LeetCode135test()
        {
            var lc164 = new Leetcode135();
            int[] input = new int[6] { 1,3,2,2,2,1 };
            var rr = lc164.Candy(input);
            
            Assert.AreEqual(8, rr);
        }

        [TestMethod]
        public void LeetCode135test3()
        {
            var lc164 = new Leetcode135();
            int[] input = new int[5] { 1, 3, 2, 2, 1 };
            var rr = lc164.Candy(input);

            Assert.AreEqual(7, rr);
        }

        [TestMethod]
        public void LeetCode135test2()
        {
            var lc164 = new Leetcode135();
            int[] input2 = new int[3] { 1, 0, 2 };
            var rr2 = lc164.Candy(input2);
            Assert.AreEqual(5, rr2);
        }

        [TestMethod]
        public void LeetCode135test4()
        {
            var lc164 = new Leetcode135();
            int[] input2 = new int[7] { 1,6,10,8,7,3,2};
            var rr2 = lc164.Candy(input2);
            Assert.AreEqual(18, rr2);
        }


        [TestMethod]
        public void LeetCode39test4()
        {
            var lc39 = new Leetcode39();
            int[] input2 = new int[4] {2,7,3,6 };
            var rr2 = lc39.CombinationSum_3(input2,7);
            Assert.AreEqual(2, rr2.Count);
        }

        [TestMethod]
        public void LeetCode39test5()
        {
            var lc39 = new Leetcode39();
            int[] input2 = new int[4] { 2, 7, 3, 6 };
            var rr2 = lc39.CombinationSum_4(input2, 7);
            Assert.AreEqual(2, rr2.Count);
        }

        [TestMethod]
        public void LeetCode40Test()
        {
            var lc39 = new Leetcode40();
            int[] input2 = new int[5] { 2,5,2,1,2};
            var rr2 = lc39.CombinationSum2(input2,5);
            Assert.AreEqual(2, rr2.Count);
        }

        [TestMethod]
        public void LeetCode209Test()
        {
            var lc39 = new Leetcode209();
            int[] input2 = new int[6] { 2, 3,1, 2, 4,3 };
            var rr2 = lc39.MinSubArrayLen(7,input2);
            Assert.AreEqual(2, rr2);
        }

        [TestMethod]
        public void LeetCode239Test()
        {
            var lc39 = new Leetcode239();
            int[] input2 = new int[8] { 1,3,-1,-3,5,3,6,7 };
            var rr2 = lc39.MaxSlidingWindow( input2, 3);
            Assert.AreEqual(2, rr2);
        }
    }
}
