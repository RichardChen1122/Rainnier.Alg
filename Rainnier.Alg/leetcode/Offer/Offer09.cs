using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode.Offer
{
    public class CQueue
    {
        private Stack<int> inStack;
        private Stack<int> outStack;

        public CQueue()
        {
            inStack = new Stack<int>();
            outStack = new Stack<int>();
        }

        public void AppendTail(int value)
        {
            inStack.Push(value);
        }

        public int DeleteHead()
        {
            if(outStack.Count == 0)
            {
                if(inStack.Count == 0)
                {
                    return -1;
                }
                else
                {
                    while(inStack.Count > 0)
                    {
                        outStack.Push(inStack.Pop());
                    }
                }
            }

            return outStack.Pop();
            
        }
    }
}
