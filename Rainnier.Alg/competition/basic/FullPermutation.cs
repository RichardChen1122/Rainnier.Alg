using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.competition.basic
{
    public class FullPermutation
    {
        public List<string> Execute(string str)
        {
            var result = new List<string>();
            string temp = "";
            DFS(result, new bool[3], 0, str, temp);
            return result;
        }

        public void DFS(List<string> list, bool[] visisted, int depth, string str, string result)
        {
            if (depth == str.Length)
            {
                list.Add(result);
                return;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (visisted[i])
                {
                    continue;
                }
                result = result + str[i];

                visisted[i] = true;

                DFS(list, visisted, depth+1, str, result); // 最初写成  DFS(list, visisted, depth++, str, result); 是有问题的
                result = result.Remove(result.Length-1);
                visisted[i] = false;

            }
        }
    }
}
