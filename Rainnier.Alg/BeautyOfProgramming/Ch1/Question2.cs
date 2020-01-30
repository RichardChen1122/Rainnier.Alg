using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.BeautyOfProgramming.Ch1
{
    
    class Question2
    {
        public void Anwser()
        {
            var c = new Cheer();

            for (c.A = 1; c.A <= 9; c.A++)
            {
                for (c.B = 1; c.B <= 9; c.B++)
                {
                    if (c.A % 3 != c.B % 3)
                    {
                        Console.WriteLine($"A={c.A}，B={c.B}");
                    }
                }
            }

        }

        
    }

    struct Cheer
    {
        public byte A { get; set; }
        public byte B { get; set; }
    }
}
