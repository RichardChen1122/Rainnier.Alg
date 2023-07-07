using System;
using System.Collections.Generic;
using System.Management.Instrumentation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rainnier.Alg;
using Rainnier.Alg.arr;
using Rainnier.Alg.leetcode;
using Rainnier.Alg.leetcode.LCP;
using Rainnier.Alg.leetcode.Offer;
using Rainnier.Alg.tree.model;
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

        [TestMethod]
        public void LeetCode310Test()
        {
            var lc39 = new Leetcode310();
            int[] input2 = new int[2] { 0,1 };
            int[] input1 = new int[2] { 0,2 };
            int[] input4 = new int[2] { 0,3 };
            int[] input3 = new int[2] { 3,4 };
            int[][] test = new int[4][];
            test[0] = input2;
            test[1] = input1;
            test[2] = input3;
            test[3] = input4;
            var rr2 = lc39.FindMinHeightTrees(5, test);
            Assert.AreEqual(2, rr2.Count);
        }

        [TestMethod]
        public void LeetCode851Test()
        {
            var lc39 = new Leetcode851();
            int[] input2 = new int[2] { 1,0 };
            int[] input1 = new int[2] { 2,1 };
            int[] input4 = new int[2] { 3,1 };
            int[] input3 = new int[2] { 3, 7 };
            int[] input5 = new int[2] { 4,3 };
            int[] input6 = new int[2] { 5,3 };
            int[] input7 = new int[2] { 6,3 };
            int[][] test = new int[7][];
            test[0] = input2;
            test[1] = input1;
            test[2] = input3;
            test[3] = input4;
            test[4] = input5;
            test[5] = input6;
            test[6] = input7;
            var rr2 = lc39.LoudAndRich(test, new int[8] { 3,2,5,4,6,1,7,0});
            Assert.AreEqual(2, rr2.Length);
        }

        [TestMethod]
        public void LeetCode26Test()
        {
            var lc39 = new Leetcode26();
            var rr2 = lc39.RemoveDuplicates(new int[3] { 1,2,2});
            Assert.AreEqual(2, rr2);
        }

        [TestMethod]
        public void LeetCode92Test()
        {
            var lc39 = new Leetcode92();
            var node5 = new ListNode(5);
            var node4 = new ListNode(4, node5);
            var node3 = new ListNode(3, node4);
            var node2 = new ListNode(2, node3);
            var node1 = new ListNode(1, node2);
            var rr2 = lc39.ReverseBetween(node1,2,4);
            Assert.AreEqual(2, rr2);
        }

        [TestMethod]
        public void Offer04Test()
        {
            var lc39 = new Offer04();
            var a1 = new int[5] { 3, 5, 9, 9, 14 };
            var a2 = new int[5] {7,8,11,15,15};
            var a3 = new int[5] {8,10,16,16,17};
            var intpu = new int[3][] { a1, a2, a3 };
            var rr2 = lc39.FindNumberIn2DArray(intpu, 12);
            Assert.AreEqual(2, rr2);
        }

        [TestMethod]
        public void Offer12Test()
        {
            var lc39 = new Offer12();
            var a1 = new char[4] { 'A', 'B','C','E' };
            var a2 = new char[4] { 'S', 'F', 'C', 'S' };
            var a3 = new char[4] { 'A', 'D', 'E', 'E' };
            var intpu = new char[3][] { a1, a2, a3 };
            var rr2 = lc39.Exist(intpu, "ABCCED");
            Assert.AreEqual(true, rr2);
        }

        [TestMethod]
        public void Offer16Test()
        {
            var lc39 = new Offer16();

            var rr2 = lc39.MyPow(2.0, -2);
            Assert.AreEqual(true, rr2);
        }

        [TestMethod]
        public void Offer33Test()
        {
            var lc39 = new Offer33();

            var rr2 = lc39.VerifyPostorder(new int[8] { 1,2,5,10,6,9,4,3});
            Assert.AreEqual(false, rr2);
        }

        [TestMethod]
        public void Offer17Test()
        {
            var lc39 = new Offer17();

            var rr2 = lc39.printNumbers(3);
            Assert.AreEqual(false, rr2);
        }

        //[3,30,34,5,9]

        [TestMethod]
        public void Offer45Test()
        {
            var lc39 = new Offer45();

            lc39.QuickSort(new int[3] {1,1,1}, 0,2);
            Assert.AreEqual(false, false);
        }

        [TestMethod]
        public void Offer1823Test()
        {
            var lc39 = new Leetcode1823();

            var ret = lc39.FindTheWinner(5,2);
            Assert.AreEqual(3, ret);
        }

        [TestMethod]
        public void Offer643Test()
        {
            var lc39 = new Leetcode643();

            var ret = lc39.FindMaxAverage(new int[6] { 1, 12, -5, -6, 50, 3 },4);
            Assert.AreEqual(3, ret);
        }

        [TestMethod]
        public void OfferHanotaTest()
        {
            var lc39 = new Interview08_06();

            var A = new List<int>() { 0 };
            var B = new List<int>() ;
            var C = new List<int>() ;
            lc39.Hanota(A, B, C);
            Assert.AreEqual(3, 3);
        }

        [TestMethod]
        public void Leetcode16_01Test()
        {
            var lc39 = new Leetcode16_01();


            var ret = lc39.DivingBoard(1,2,3);
            Assert.AreEqual(3, 3);
        }

        [TestMethod]
        public void Offer001_Test()
        {
            var lc39 = new Offer_001();


            var ret = lc39.Divide(15,2);
            Assert.AreEqual(7, ret);
        }

        [TestMethod]
        public void Interview_Test()
        {
            var lc39 = new Interview();


            var ret = lc39.ValidString("{");
            Assert.AreEqual(0, ret);
        }

        [TestMethod]
        public void Interview_Test2()
        {
            var lc39 = new Interview();


            var ret = lc39.ValidString("123456789");
            Assert.AreEqual(9, ret);
        }

        [TestMethod]
        public void Interview_Test3()
        {
            var lc39 = new Interview();


            var ret = lc39.ValidString("123445{j[d]j}9");
            Assert.AreEqual(14, ret);
        }

        [TestMethod]
        public void Interview_Test4()
        {
            var lc39 = new Interview();


            var ret = lc39.ValidString("12[3445{j[d]j}9");
            Assert.AreEqual(12, ret);
        }

        [TestMethod]
        public void Interview_Test5()
        {
            var lc39 = new Interview();


            var ret = lc39.ValidString("12[34}45{j[d]j}9");
            Assert.AreEqual(10, ret);
        }
        [TestMethod]
        public void Interview_Test6()
        {
            var lc39 = new Interview();


            var ret = lc39.ValidString("12[34}45{j[d]j}9{}");
            Assert.AreEqual(12, ret);
        }

        [TestMethod]
        public void Interview_Test7()
        {
            var lc39 = new Interview();


            var ret = lc39.ValidString("12[34}45{j[d]j}9{12");
            Assert.AreEqual(10, ret);
        }

        [TestMethod]
        public void Interview_Test8()
        {
            var lc39 = new Interview();


            var ret = lc39.ValidString("12[34}45{j[d]j}9[}{000000001223}]34{");
            Assert.AreEqual(14, ret);
        }

        [TestMethod]
        public void Interview_Test9()
        {
            var lc39 = new Interview();


            var ret = lc39.ValidString("12[34]45{j[d]j}9]");
            Assert.AreEqual(16, ret);
        }

        [TestMethod]
        public void Leetcode139Test()
        {
            var lc39 = new Leetcode139();

            var rr2 = lc39.WordBreak("aaaaaaa", new List<string>() { "aaaa", "aaa"});
            Assert.AreEqual(true, rr2);
        }

        [TestMethod]
        public void Leetcode139Test2()
        {
            var lc39 = new Leetcode139();

            var rr2 = lc39.WordBreak2("leetcode", new List<string>() { "leet", "code" });
            Assert.AreEqual(true, rr2);
        }

        [TestMethod]
        public void Leetcode139Test3()
        {
            var lc39 = new Leetcode139();

            var rr2 = lc39.WordBreak3("leetcode", new List<string>() { "leet", "code" });
            Assert.AreEqual(true, rr2);
        }

        [TestMethod]
        public void Leetcode139Test4()
        {
            var lc39 = new Leetcode139();

            var rr2 = lc39.WordBreak3("aaaaaaa", new List<string>() { "aaa", "aaaa" });
            Assert.AreEqual(true, rr2);
        }

        [TestMethod]
        public void Leetcode139Test5()
        {
            var lc39 = new Leetcode139();

            var rr2 = lc39.WordBreak3("cars", new List<string>() { "car", "ca", "rs" });
            Assert.AreEqual(true, rr2);
        }

        //[1,2,3,6,2,3,4,7,8]

        [TestMethod]
        public void Leetcode846Test5()
        {
            var lc39 = new Leetcode846();

            var rr2 = lc39.IsNStraightHand(new int[9] { 1, 2, 3, 6, 2, 3, 4, 7, 8 },3);
            Assert.AreEqual(true, rr2);
        }

        [TestMethod]
        public void Leetcode846Test()
        {
            var lc39 = new Leetcode846();

            var rr2 = lc39.IsNStraightHand(new int[2] { 5,1 }, 1);
            Assert.AreEqual(true, rr2);
        }

        [TestMethod]
        public void Leetcode846Test2()
        {
            var lc39 = new Leetcode846();

            var rr2 = lc39.IsNStraightHand(new int[6] { 1,1,2,2,3,3 }, 2);
            Assert.AreEqual(true, rr2);
        }

        [TestMethod]
        public void LCP40Test2()
        {
            var lc39 = new LCP40();

            var rr2 = lc39.MaxmiumScore(new int[4] { 1, 3,4,5 }, 4);
            Assert.AreEqual(18, rr2);
        }

        [TestMethod]
        public void Leetcode300()
        {
            var lc39 = new Leetcode300();

            var rr2 = lc39.LengthOfLIS2(new int[6] {0,1,0,3,2,3});
            Assert.AreEqual(4, rr2);
        }
    }
}
