using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.arr
{
    public class Interview
    {
        public int ValidString(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            int start = 0;
            int end = -1;

            int length = str.Length;
            var stack = new Stack<int>();

            int longestValid = 0;

            var map = new Dictionary<char, char>()
            {
                { '}','{'},
                { ']','['},
                { ')','('},
            };

            for (int i = 0; i < length; i++)
            {

                if (str[i] == '{' || str[i] == '[' || str[i] == '(')
                {
                    stack.Push(i);
                }
                else if (str[i] == '}' || str[i] == ']' || str[i] == ')')
                {
                    if (stack.Count == 0)
                    {
                        start = i + 1;
                        end = i;
                        continue;
                    }
                    else
                    {
                        var top = stack.Peek();
                        if (str[top] != map[str[i]])
                        {
                            start = i + 1;
                            end = i;
                            stack.Clear();
                            continue;
                        }
                        else
                        {
                            stack.Pop();
                        }
                    }
                }

                if (stack.Count == 0)
                {
                    end = i;
                    if (end >= start)
                    {
                        longestValid = Math.Max(longestValid, end - start + 1);
                    }
                }

            }

            if (stack.Count != 0)
            {
                longestValid = Math.Max(longestValid, str.Length - stack.Peek() - 1);
            }

            return longestValid;
        }
    }
}
