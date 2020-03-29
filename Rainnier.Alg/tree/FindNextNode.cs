using Rainnier.Alg.tree.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.tree
{
    class FindNextNode
    {
        //遍历算法
        public NodeWithParent Solve(NodeWithParent target)
        {
            var temp = target;
            while (temp.Parent != null)
            {
                temp = temp.Parent;
            }
            var stack = new Stack<NodeWithParent>();
            NodeWithParent current = temp;

            NodeWithParent result = null;

            while (current != null)
            {
                stack.Push(current);
                current = current.Left;
                while (current == null && stack.Count > 0)
                {
                    if (result == target)
                    {
                        return stack.Peek();
                    }
                    result = stack.Pop();

                    current = result.Right;
                }
            }

            return null;
        }

        public NodeWithParent Solve2(NodeWithParent target)
        {
            var temp = target;
            while (temp.Parent != null)
            {
                temp = temp.Parent;
            }
            var stack = new Stack<NodeWithParent>();
            NodeWithParent current = temp;

            NodeWithParent result = null;

            while (current != null)
            {
                stack.Push(current);
                current = current.Left;
                while (current == null && stack.Count > 0)
                {
                    if (result == target)
                    {
                        return stack.Peek();
                    }
                    result = stack.Pop();

                    current = result.Right;
                }
            }

            return null;
        }
    }
}
