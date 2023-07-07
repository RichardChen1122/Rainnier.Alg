using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.competition.basic
{
    //算法竞赛（上）， P39
    internal class FindWindowSum
    {
        public List<int[]> Func(int[] array, int target)
        {
            var result = new List<int[]>();

            var length = array.Length;

            int i=0;
            int j=0;

            int sum = array[0];

            while (j<length) 
            { 
                if (sum >= target)
                {
                    if (sum == target)
                    {
                        result.Add(new int[] { i, j });
                    }
                    sum-= array[i];
                    i++;
                    if (i > j)
                    {
                        sum = array[i];
                        j++;
                    }
                } 
                else if (sum < target) 
                {
                    j++;
                    sum += array[j];
                }
                
            }

            return result;
        }
    }
}
