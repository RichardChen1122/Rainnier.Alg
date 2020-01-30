using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.str
{
    class RemoveSpecialChar
    {
        public string Remove(string origin, string special)
        {
            HashSet<char> set = new HashSet<char>();

            Dictionary<char, int> dic = new Dictionary<char, int>();

            int[] arr = new int[256];
  

            for (int i = 0; i < special.Length; i++)
            {

                dic[special[i]] = 1;
                
            }

            StringBuilder strBuilder = new StringBuilder();
            for(int i = 0; i < origin.Length; i++)
            {
                if (!(dic.TryGetValue(origin[i], out int val) && val==1))
                {
                    strBuilder.Append(origin[i]);
                }
            }

            return strBuilder.ToString();
        }
    }
}
