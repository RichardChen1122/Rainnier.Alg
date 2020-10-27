using Rainnier.Alg.arr;
using Rainnier.Alg.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rainnier.Alg.BeautyOfProgramming.Ch1;
using Rainnier.Alg.BeautyOfProgramming.Ch2;
using System.Collections;
using Rainnier.Alg.linkList;
using Rainnier.Alg.graph.model;

namespace Rainnier.Alg
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Leetcode1439();
            int[][] mat = new int[2][];
            mat[0] = new int[3] { 1, 3, 11 };
            mat[1] = new int[3] { 2, 4, 6 };
            test.ShowSums(mat);
            //DemoGraph g = new DemoGraph();
            //g.AddVertex(1);
            //g.AddVertex(2);
            //g.AddVertex(3);
            //g.AddVertex(4);
            //g.AddVertex(5);
            //g.AddEdge(0, 1);
            //g.AddEdge(0, 2);
            //g.AddEdge(2, 3);
            //g.AddEdge(1, 3);
            //g.AddEdge(1, 4);
            //g.AddEdge(3, 4);
            //g.TopologySort();
            Console.ReadKey();


            int[][] superArray = new int[3][] { new int[] { 4, 5 }, new int[] { 1, 2 }, new int[] { 4, 9 } };

            Console.WriteLine(Question19.Solve(superArray, new int[] { 1, 6 }));
  
            int[] arr55 = { -4, -6, -4, -6, -4, 100 };
            int[] arr6 = { 1,2,3,3 };
            Console.WriteLine(MaximumLengthOfTargetSum.Solve(arr6, 5));


            Console.WriteLine(FindOnlyOnce.Solve(arr55, 3));
            //var dete = new BeautyOfProgramming.Ch1.Question1();
            //var dete = new BeautyOfProgramming.Ch1.Question1();
            //var dete = new BeautyOfProgramming.Ch1.Question1();
            //var dete = new BeautyOfProgramming.Ch1.Question1();
            int[] arr = { 1, -2, 3, 5, -2, 6, -1,6,-100,5,2,3 };
            int[] arr3 = { 1,2};
            int[] arr4 = { 1,2,5,8,10 };
            string[] arr5 = { "bc", "de" };
            Console.WriteLine(Question16.Solve2(arr3));
            //Question1.ConsumeCPU(40); 
            //BeautyOfProgramming.Ch1.Question1.SinConsumeCPU();
            var a = new FrogJump();
            var b = new FindOnce();
            var c = new FindFirstNotOccur();
            var d = new StringSubstitution();
            int[] arr1 = { 3, 15, 3, 1,4, 1, 4 };
            var t = d.Substitution("123acdabc", "abc", "X");

            var q14 = new Question14();
            Console.WriteLine(q14.MaximumSum2(arr));
            var q5 = new Question5();
            Console.WriteLine(q5.Solve(arr,3).PrintString());
            
            
            int tt = 'a';
            Console.ReadKey();
        }
    }

    public static class Extension
    {
        public static string PrintString(this int[] arr)
        {
            StringBuilder b = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != arr.Length - 1)
                {
                    b.Append($"{arr[i]},");
                }
                else
                {
                    b.Append($"{arr[i]}");
                }
            }

            return b.ToString();
        }
    }
}
