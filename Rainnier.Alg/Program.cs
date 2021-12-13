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
using Rainnier.Alg.leetcode;
using Rainnier.Alg.memory;
using System.Threading;

namespace Rainnier.Alg
{
    class Program
    {
        static List<object> list;
        static void Main(string[] args)
        {
            var gc = new GarbageCollection();

           //gc.MemoryLeak();

            list = new List<object>();
            for (int i = 0; i < 100000; i++)
            {
                list.Add(new object());
            }

            gc.TestGC();    

            Thread.Sleep(15000);
            list = null;
            GC.Collect();   
            

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
