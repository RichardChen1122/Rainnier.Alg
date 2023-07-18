using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.competition.Search
{
    //八数问题， 算法竞赛 例3.2
    public class EightNumberProblem
    {
        public int Execute()
        {
            int result = 0;

            string str = "012345678";
            string target = "087654321";
            var queue = new Queue<string>();
            var set = new HashSet<string>();

            queue.Enqueue(str);
            set.Add(str);

            while (queue.Any())
            {
                var head = queue.Dequeue();
                result++;

                if (head == target)
                {
                    break;
                }

                var nexts = Jump(head);

                foreach (var item in nexts)
                {
                    if (!set.Contains(item))
                    {
                        set.Add(item);
                        queue.Enqueue(item);
                    }
                }
            }

            return result;
        }

        private string[] Jump(string str)
        {
            var result = new string[4];

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '0') 
                {
                    result[0] = Swap(str, i, (i + 9 - 2) % 9);
                    result[1] = Swap(str, i, (i + 9 - 1) % 9);
                    result[2] = Swap(str, i, (i + 1) % 9);
                    result[3] = Swap(str, i, (i + 2) % 9);

                    break;
                }
            }

            return result;
        }

        private string Swap(string str, int index, int index2)
        {
            var charArray = str.ToCharArray();
            var temp = charArray[index];
            charArray[index] = charArray[index2];
            charArray[index2] = temp;

            return new string(charArray);

        }
    }
}
