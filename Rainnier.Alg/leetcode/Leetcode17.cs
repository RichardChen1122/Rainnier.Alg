using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode17
    {
        public IList<string> LetterCombinations(string digits)
        {
            IList<string> result = new List<string>();
            if (string.IsNullOrEmpty(digits))
            {
                return result;
            }

            
            var map = new Dictionary<char, IList<string>>();
            map.Add('2', new List<string> { "a", "b", "c" });
            map.Add('3', new List<string> { "d", "e", "f" });
            map.Add('4', new List<string> { "g", "h", "i" });
            map.Add('5', new List<string> { "j", "k", "l" });
            map.Add('6', new List<string> { "m", "n", "o" });
            map.Add('7', new List<string> { "p", "q", "r", "s" });
            map.Add('8', new List<string> { "t", "u", "v" });
            map.Add('9', new List<string> { "w", "x", "y", "z" });

            

            char[] list = digits.ToCharArray();

            if (list.Length < 2)
            {
                return map[list[0]];
            }

            result = Generate(map[list[0]], map[list[1]]);

            for (int i = 2; i < list.Length; i++)
            {
                result = Generate(result, map[list[i]]);
            }

            return result;
        }

        private IList<string> Generate(IList<string> baseList, IList<string> appendList)
        {
            var result = new List<string>();
            for (int i = 0; i < baseList.Count; i++)
            {
                for (int j = 0; j < appendList.Count; j++)
                {
                    result.Add(baseList[i] + appendList[j]);
                }
            }

            return result;
        }


        public IList<string> LetterCombinations_2(string digits)
        {
            List<string> result = new List<string>();
            if (string.IsNullOrEmpty(digits))
            {
                return result;
            }

            var map = new Dictionary<char, IList<string>>();
            map.Add('2', new List<string> { "a", "b", "c" });
            map.Add('3', new List<string> { "d", "e", "f" });
            map.Add('4', new List<string> { "g", "h", "i" });
            map.Add('5', new List<string> { "j", "k", "l" });
            map.Add('6', new List<string> { "m", "n", "o" });
            map.Add('7', new List<string> { "p", "q", "r", "s" });
            map.Add('8', new List<string> { "t", "u", "v" });
            map.Add('9', new List<string> { "w", "x", "y", "z" });

            char[] inputList = digits.ToCharArray();

            result.AddRange(map[inputList[0]]);

            BackTrack(result, map, inputList, 1);

            return result;
        }

        private void BackTrack(IList<string> baseList, Dictionary<char, IList<string>> map, char[] inputList, int index)
        {
            if( index== inputList.Length)
            {
                return;
            }
            var toAppendList = map[inputList[index]];

            var length = baseList.Count;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < toAppendList.Count; j++)
                {
                    baseList.Add(baseList[0] + toAppendList[j]);
                }
                baseList.RemoveAt(0);
            }


            BackTrack(baseList, map, inputList, index + 1);
        }
    }
}
