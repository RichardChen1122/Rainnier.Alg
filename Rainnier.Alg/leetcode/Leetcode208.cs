using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode.lc208
{
    public class Leetcode208
    {

    }

    public class TrieNode
    {
        public string Char { get; set; }
        public Dictionary<char, TrieNode> Nexts { get; set; }
        public bool WordFlag { get; set; }
    }

    public class Trie
    {
        private TrieNode root;

        public Trie()
        {
            root = new TrieNode()
            {
                Char = string.Empty,
                Nexts = new Dictionary<char, TrieNode>(),
                WordFlag = false
            };
        }

        public void Insert(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return; 
            }

            var current = root;

            for (int i = 0; i < word.Length; i++)
            {
                if (!current.Nexts.ContainsKey(word[i]))
                {
                    var newNode = new TrieNode()
                    {
                        Char = word[i].ToString(),
                        Nexts = new Dictionary<char, TrieNode>(),
                        WordFlag = i == word.Length - 1
                    };
                    current.Nexts.Add(word[i], newNode);
                }
                else
                {
                    if(i == word.Length - 1)
                    {
                        current.Nexts[word[i]].WordFlag = true;
                    }
                }

                current = current.Nexts[word[i]];
                
            }
        }

        public bool Search(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return false;
            }

            var current = root;

            for (int i = 0; i < word.Length; i++)
            {
                if (!current.Nexts.ContainsKey(word[i]))
                {
                    return false;
                }

                if(i == word.Length - 1 && !current.Nexts[word[i]].WordFlag) { return false; }

                current = current.Nexts[word[i]];
            }

            return true;
        }

        public bool StartsWith(string prefix)
        {
            if (string.IsNullOrEmpty(prefix))
            {
                return false;
            }

            var current = root;

            for (int i = 0; i < prefix.Length; i++)
            {
                if (!current.Nexts.ContainsKey(prefix[i]))
                {
                    return false;
                }

                current = current.Nexts[prefix[i]];
            }

            return true;
        }
    }

    /**
     * Your Trie object will be instantiated and called as such:
     * Trie obj = new Trie();
     * obj.Insert(word);
     * bool param_2 = obj.Search(word);
     * bool param_3 = obj.StartsWith(prefix);
     */
}
