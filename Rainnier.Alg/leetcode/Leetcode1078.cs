using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Leetcode1078
    {
        public string[] FindOcurrences(string text, string first, string second)
        {
            if (string.IsNullOrEmpty(text))
            {
                return Array.Empty<string>();
            }

            var array = text.Split(' ');

            var result = new List<string>();

            for (int i = 0; i < array.Length-2; i++)
            {
                if(string.Equals(array[i], first, StringComparison.InvariantCultureIgnoreCase)
                    && string.Equals(array[i+1],second, StringComparison.InvariantCultureIgnoreCase)
                    ) {
                    result.Add(array[i + 2]);
                }

                
            }

            return result.ToArray();
        }
    }
}
