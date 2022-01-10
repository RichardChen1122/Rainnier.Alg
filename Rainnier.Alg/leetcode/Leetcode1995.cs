using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    //统计特殊四元组
    public class Leetcode1995
    {
        public int CountQuadruplets(int[] nums)
        {
            if(nums == null || nums.Length < 4)
            {
                return 0;
            }

            int ret = 0;

            var length = nums.Length;

            for (int i = 0; i < length-3; i++)
            {
                for (int j = i+1; j < length - 2; j++)
                {
                    for (int k = j+1; k < length-1; k++)
                    {
                        var result  = nums[i]+nums[j]+nums[k];
                        var p = k+1;
                        while (p < nums.Length)
                        {
                            if(result == nums[p])
                            {
                                ret++;
                            }
                            p++;
                        }
                    }
                }

            }
            return ret;
        }

        public int CountQuadruplets2(int[] nums)
        {
            if (nums == null || nums.Length < 4)
            {
                return 0;
            }

            int ret = 0;

            var length = nums.Length;
            var map = new Dictionary<int, int>();

            for (int c = length-2; c >=2; c--)
            {
                if (!map.ContainsKey(nums[c+1]))
                {
                    map.Add(nums[c+1], 1);
                }
                else
                {
                    map[nums[c+1]]++;
                }
                for (int a = 0; a < c-1 ; a++)
                {
                    for (int b = a + 1; b < c; b++)
                    {
                        var result = nums[a] + nums[b] + nums[c];
                        if (map.ContainsKey(result))
                        {
                            ret+=map[result];
                        }
                    }
                }
            }
            
            return ret;
        }

        public int CountQuadruplets3(int[] nums)
        {
            if (nums == null || nums.Length < 4)
            {
                return 0;
            }

            int ret = 0;

            var length = nums.Length;
            var map = new Dictionary<int, int>();

            var listD = new List<int>() { nums[length - 1] };

            for (int b = length - 3; b >= 1; b--)
            {
                foreach(var x in listD)
                {
                    if (!map.ContainsKey(x-nums[b+1]))
                    {
                        map.Add(x - nums[b + 1], 1);
                    }
                    else
                    {
                        map[x - nums[b + 1]]++;
                    }
                }

                listD.Add(b+1);
                
                for (int a = 0; a < b; a++)
                {
                    
                        var result = nums[a] + nums[b];
                        if (map.ContainsKey(result))
                        {
                            ret += map[result];
                        }
                    
                }
            }

            return ret;
        }
    }
}
