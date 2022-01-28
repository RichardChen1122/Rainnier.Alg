using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{
    public class Interview16_15
    {
        public int[] MasterMind(string solution, string guess)
        {
            var result = new int[2];

            var dicSolution = new Dictionary<char, int>()
            {
                { 'R',0},
                { 'Y',0},
                { 'G',0},
                { 'B',0}
            };

            var dicGuess = new Dictionary<char, int>()
            {
                { 'R',0},
                { 'Y',0},
                { 'G',0},
                { 'B',0}
            };

            for (int i = 0; i < solution.Length; i++)
            {
                if (solution[i] == guess[i])
                {
                    result[0]++;
                }
                else
                {
                    dicSolution[solution[i]]++;
                    dicGuess[guess[i]]++;
                }
            }

            foreach (var item in dicGuess.Keys)
            {
                result[1] += Math.Min(dicGuess[item], dicSolution[item]);
            }

            return result;
        }

    }
}
