using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.memory
{
    internal class GarbageCollection
    {
        private List<object> test;
        public void MemoryOverflow()
        {
            var tes = new bool[long.MaxValue];
        }

        public void MemoryLeak()
        {

        }

        public void TestGC()
        {
            test = new List<object>();
            for (int i = 0; i < 100000; i++)
            {
                test.Add(new object());
            }
        }
    }

    internal class StartObject
    {

    }
}
