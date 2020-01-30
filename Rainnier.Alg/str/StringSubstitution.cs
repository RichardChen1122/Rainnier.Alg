using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.str
{
    class StringSubstitution
    {
        public string Substitution(string str, string from, string to)
        {
            StringBuilder result = new StringBuilder();

            int left = 0;

            while (left < str.Length)
            {
                if (str[left] != from[0])
                {
                    result.Append(str[left]);
                    left++;
                }
                else
                {
                    int currentLeft = left;
                    int i = 0;
                    for (; i < from.Length && currentLeft < str.Length; i++)
                    {
                        if (str[currentLeft++] != from[i])
                        {
                            break;                            
                        }                    
                    }

                    if (i== from.Length)
                    {
                        result.Append(to);
                        left = currentLeft;
                    }
                    else
                    {
                        result.Append(str[left]);
                        left++;
                    }

                }
            }


            return result.ToString();

        }
    }
}
