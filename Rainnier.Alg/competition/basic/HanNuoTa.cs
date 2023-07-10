using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.competition.basic
{
    public class HanNuoTa
    {
        int sum = 0;
        public void Hanoi(char x, char y, char z, int n)
        {
            if (n == 1)
            {
                sum++;

                Console.WriteLine($"# {sum}: {x} -> {z}");
            }
            else
            {
                Hanoi(x, z, y, n - 1); // 把n-1 小盘移动到y
                sum++;
                Console.WriteLine($"# {sum}: {x} -> {z}"); // 把n 从x 移动到z
                Hanoi(y, x, z, n - 1); // 把n-1 从y 移动到z
            }
        }

        public void Execute(int n)
        {
            Hanoi('A', 'B', 'C', n);
            Console.WriteLine("End");
        }
    }
}
