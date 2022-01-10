using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode139
    {
        //这个方法如果不加memory时间复杂度过高, 会超时
        public bool WordBreak(string s, IList<string> wordDict)
        {
            var set = wordDict.ToHashSet();

            var memory = new Dictionary<string, bool>();

           return DFS(s, set, memory); 

        }

        public bool DFS(string s, HashSet<string> set, Dictionary<string, bool> memory)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            if (memory.ContainsKey(s))
            {
                return memory[s];
            }
            for (int i = 1; i <= s.Length; i++)
            {
                if (set.Contains(s.Substring(0, i)))
                {
                    if (DFS(s.Substring(i), set, memory))
                    {
                        if (!memory.ContainsKey(s.Substring(i)))
                        {
                            memory.Add(s.Substring(i), true);
                        }
                        return true;
                    }
                    else
                    {
                        if (!memory.ContainsKey(s.Substring(i)))
                        {
                            memory.Add(s.Substring(i), false);
                        }
                    }
                }
            }

            return false;
        }

        //这个方法如果不加memory时间复杂度过高, 会超时
        public bool WordBreak2(string s, IList<string> wordDict)
        {
            var set = wordDict.ToHashSet();

            var length = s.Count();

            var dp= new bool[length+1];

            dp[0] = true;


            for (int i = 1; i <= length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (dp[j])
                    {
                        var sub = s.Substring(j, i - j);

                        if (set.Contains(sub))
                        {
                            dp[i]  = true;
                        }
                    }
                }
            }

            return dp[length];

        }

        public bool WordBreak3(string s, IList<string> wordDict)
        {
            var trie = new Trie();
            for (int i = 0; i < wordDict.Count; i++)
            {
                trie.Insert(wordDict[i]);
            }



            return trie.DpSearch(s, 0, new Dictionary<int, bool>());

        }

      

       


        private class TrieNode
        {
            public TrieNode[] Children { get; set; }
            public bool IsEnd { get; set; }

            public TrieNode()
            {
                IsEnd = false;
                Children = new TrieNode[26];
            }

            public TrieNode(bool end)
            {
                IsEnd = end;
                Children = new TrieNode[26];
            }
        }

        public class Trie
        {
            private TrieNode root;

            public Trie()
            {
                root = new TrieNode();
            }

            public void Insert(string str)
            {
                if (string.IsNullOrEmpty(str))
                {
                    return;
                }
                var current = root;

                for (int i = 0; i < str.Length; i++)
                {
                    if(current.Children[str[i] - 'a'] == null)
                    {
                        current.Children[str[i] - 'a'] = new TrieNode(i == str.Length - 1);
                    }
                    else
                    {
                        if(i == str.Length - 1)
                        {
                            current.Children[str[i] - 'a'].IsEnd = true;
                        }
                    }
                    current = current.Children[str[i] - 'a'];
                }
            }

            public bool Search(string str)
            {
                if (string.IsNullOrEmpty(str))
                {
                    return false;
                }

                var current = root;

                for (int i = 0; i < str.Length; i++)
                {
                    if(current.Children[str[i] - 'a'] == null)
                    {
                        return false;
                    }

                    if(i== str.Length - 1 && !current.Children[str[i] - 'a'].IsEnd)
                    {
                        return false;
                    }

                    current = current.Children[str[i] - 'a'];
                }

                return true;
            }

            public bool DpSearch(string str, int index, Dictionary<int, bool> memory)
            {
                if (index == str.Length)
                {
                    return true;
                }

                if (memory.ContainsKey(index))
                {
                    return memory[index];
                }

                var current = root;

                while (index < str.Length && current.Children[str[index] - 'a'] != null )
                {
                    current = current.Children[str[index] - 'a'];
                    index++;

                    if (current.IsEnd )
                    {
                        if (DpSearch(str, index, memory))
                        {
                            if (!memory.ContainsKey(index))
                            {
                                memory.Add(index, true);
                                return true;
                            }
                        }
                        else
                        {
                            if (!memory.ContainsKey(index))
                            {
                                memory.Add(index, false);
                            }
                        }
                    }
                }

                return false;
            }
        }
    }
}
