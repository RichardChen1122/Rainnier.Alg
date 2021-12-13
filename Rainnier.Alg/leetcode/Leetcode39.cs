using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode39
    {
        public IList<IList<int>> CombinationSum_4(int[] candidates, int target)
        {
            var result = new List<IList<int>>();
            var length = candidates.Length;
            if (length == 0)
            {
                return result;
            }

            Array.Sort(candidates);

            var collection = new List<int>();
            BackTrack_4(candidates, target, result, collection, 0);

            return result;
        }

        private void BackTrack_4(int[] candidates, int target, IList<IList<int>> result, IList<int> collection, int index)
        {
            if(target == 0)
            {
                result.Add(new List<int>(collection));
                return;
            }

            if (target < 0)
            {
                return;
            }

            for (int i = index; i < candidates.Length; i++)
            {
                if (candidates[i] > target)
                {
                    break;
                }
                collection.Add(candidates[i]);
                BackTrack_4(candidates, target - candidates[i], result, collection, i);
                collection.RemoveAt(collection.Count-1);
            }
        }

        public IList<IList<int>> CombinationSum_3(int[] candidates, int target)
        {

            var result = new List<IList<int>>();
            var length = candidates.Length;
            if (length == 0)
            {
                return result;
            }

            var collection = new List<int>();

            BackTrack(candidates, result, collection, 0, target);

            return result;
        }

        private void BackTrack(int[] candidates, IList<IList<int>> result, IList<int> collection, int index, int target)
        {
            if(target == 0)
            {
                result.Add(new List<int>(collection));

                return;
            }

            if (target < 0 || index == candidates.Length)
            {
                return;
            }

            BackTrack(candidates, result, collection, index +1, target);
            collection.Add(candidates[index]);
            BackTrack(candidates, result, collection, index, target - candidates[index]);
            collection.RemoveAt(collection.Count-1) ;
        }

        public List<List<int>> CombinationSum(int[] candidates, int target)
        {
            ValueTuple<int, List<List<int>>>[][] dp = new ValueTuple<int, List<List<int>>>[candidates.Length + 1][];

            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = new ValueTuple<int, List<List<int>>>[target + 1];
            }

            for (int i = 0; i < target + 1; i++)
            {
                dp[0][i] = (0, null);
            }

            for (int i = 1; i < dp.Length; i++)
            {
                dp[i][0] = (1, new List<List<int>>());
            }

            for (int i = 1; i < dp.Length; i++)
            {
                for (int j = 1; j < target+1; j++)
                {
                
                    if (j - candidates[i - 1] >= 0)
                    {
                        dp[i][j].Item1 = dp[i - 1][j].Item1 + dp[i][j - candidates[i - 1]].Item1;
                        if (dp[i][j].Item1 == 0)
                        {
                            dp[i][j].Item2 = null;
                        }
                        else
                        {
                            var result = new List<List<int>>();
                            if (dp[i - 1][j].Item2 != null)
                            {
                                result.AddRange(dp[i - 1][j].Item2);
                            }

                            if (dp[i][j - candidates[i - 1]].Item2 != null)
                            {

                                var length = dp[i][j - candidates[i - 1]].Item2.Count;

                                if (length == 0)
                                {
                                    result.Add(new List<int> { candidates[i - 1] });
                                }
                                else
                                {
                                    for (int k = 0; k < length; k++)
                                    {
                                        dp[i][j - candidates[i - 1]].Item2[k].Add(candidates[i - 1]);
                                        result.Add(dp[i][j - candidates[i - 1]].Item2[k]);
                                    }
                                }
                            }
                            dp[i][j].Item2 = result;

                        }
                    }
                    else
                    {
                        dp[i][j] = dp[i - 1][j];
                    }
                    
                }
            }

            return dp[dp.Length-1][target].Item2;
        }

        public List<T> Clone<T>(object List)
        {
            using (Stream objectStream = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(objectStream, List);
                objectStream.Seek(0, SeekOrigin.Begin);
                return formatter.Deserialize(objectStream) as List<T>;
            }
        }

        public List<List<int>> CombinationSum_2(int[] candidates, int target)
        {
            var map = new Dictionary<int, List<List<int>>>();

            HashSet<int> set = candidates.ToHashSet();

            for (int i = 1; i <= target; i++)
            {
                var combination = new List<List<int>>();

                var visitedSet = new HashSet<int>();
                for (int k = 0; k < map.Count; k++)
                {
                    var factor = map.ElementAt(k).Key;
                    var anotherFactor = i - factor;
                    if (map.ContainsKey(anotherFactor))
                    {
                        if(!visitedSet.Contains(factor) && !visitedSet.Contains(anotherFactor))
                        {
                            combination.AddRange(Merge(map[factor], map[anotherFactor]));
                            visitedSet.Add(factor);
                            visitedSet.Add(anotherFactor);
                            while (map.ContainsKey(Math.Abs(factor - anotherFactor)))
                            {
                                visitedSet.Add(Math.Abs(factor - anotherFactor));
                                anotherFactor = Math.Abs(factor - anotherFactor);
                            }
                        }
                    }
                }

                if (set.Contains(i))
                {
                    var self = new List<int> { i };
                    combination.Add(self);
                    map.Add(i, combination);
                }

                if(!map.ContainsKey(i)&& combination.Count > 0)
                {
                    map.Add(i, combination);
                }
            }

            if (map.ContainsKey(target))
            {
                return map[target];
            }
            else
            {
                return new List<List<int>>();
            }
        }

        public List<List<int>> Merge(List<List<int>> left, List<List<int>> right)
        {
            var result = new List<List<int>>();
            for (int i = 0; i < left.Count; i++)
            {
                result.AddRange(Merge(left[i], right));
            }

            return result;
        }

        public List<List<int>> Merge(List<int> item, List<List<int>> right)
        {
            var result = new List<List<int>>();
            for (int i = 0; i < right.Count; i++)
            {
                var tempList = new List<int>();
                for (int j = 0; j < right[i].Count; j++)
                {
                    tempList.Add(right[i][j]);
                    
                }
                for (int k = 0; k < item.Count; k++)
                {
                    tempList.Add(item[k]);
                }
                result.Add(tempList);
            }

            return result;
        }
    }
}
