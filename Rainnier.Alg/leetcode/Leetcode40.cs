using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{

    public class Leetcode40
    {
        class Compare : IEqualityComparer<IList<int>>
        {
            public bool Equals(IList<int> x, IList<int> y)
            {
                return x.SequenceEqual(y);
            }

            public int GetHashCode(IList<int> obj)
            {
                int hashcode = 0;
                foreach (int t in obj)
                {
                    hashcode ^= t.GetHashCode();
                }
                return hashcode;
            }
        }
        public IList<IList<int>> CombinationSum_2(int[] candidates, int target)
        {
            var length = candidates.Length;
            var result = new List<IList<int>>();
            if(length == 0)
            {
                return result;
            }

            IEqualityComparer<IList<int>> compare = new Compare();

            var map = new Dictionary<IList<int>, int>(compare);
            

            var collection = new List<int>();
            var used = new bool[length];

            Array.Sort(candidates);

            var newInput = new List<int>();
            var newInputMap = new Dictionary<int, int>();
            for (int i = 0; i < length; i++)
            {
                if (!newInputMap.ContainsKey(candidates[i]))
                {
                    newInputMap.Add(candidates[i], 1);
                }
                else
                {
                    newInputMap[candidates[i]]++;
                }
            }

            for (int i = 0; i < newInputMap.Count; i++)
            {
                if ((target / newInputMap.ElementAt(i).Key) < newInputMap.ElementAt(i).Value)
                {
                    newInputMap[newInputMap.ElementAt(i).Key] = target / newInputMap.ElementAt(i).Key;
                }
            }

            foreach (var item in newInputMap)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    newInput.Add(item.Key);
                }
            }

            DFS(newInput, target, result, collection, used, 0, map);
            return result;
        }

        private void DFS(IList<int> candidates, int target, IList<IList<int>> result, List<int> collection, bool[] used, int index, Dictionary<IList<int>, int> map)
        {
            if(target == 0)
            {
                var collect = new List<int>(collection);

                if (!map.ContainsKey(collect))
                {
                    result.Add(collect);
                    map.Add(collect, 1);
                    
                }

                return;
            }

            if (target < 0)
            {
                return;
            }

            for (int i = index; i < candidates.Count; i++)
            {
                if (used[i])
                {
                    continue;
                }
                used[i] = true;
                collection.Add(candidates[i]);
                DFS(candidates, target - candidates[i], result, collection, used, i, map);
                collection.RemoveAt(collection.Count - 1);
                used[i] = false;
            }
        }

       
        List<int[]> freq = new List<int[]>();
        List<IList<int>> ans = new List<IList<int>>();
        List<int> sequence = new List<int>();

        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            Array.Sort(candidates);
            foreach (int num in candidates)
            {
                int size = freq.Count;
                if (freq.Count==0 || num != freq[size - 1][0])
                {
                    freq.Add(new int[] { num, 1 });
                }
                else
                {
                    ++freq[size - 1][1];
                }
            }
            dfs(0, target);
            return ans;
        }

        public void dfs(int pos, int rest)
        {
            if (rest == 0)
            {
                ans.Add(new List<int>(sequence));
                return;
            }
            if (pos == freq.Count || rest < freq[pos][0])
            {
                return;
            }

            dfs(pos + 1, rest);

            int most = Math.Min(rest / freq[pos][0], freq[pos][1]);
            for (int i = 1; i <= most; ++i)
            {
                sequence.Add(freq[pos][0]);
                dfs(pos + 1, rest - i * freq[pos][0]);
            }
            for (int i = 1; i <= most; ++i)
            {
                sequence.RemoveAt(sequence.Count - 1);
            }
        }
    }
}
