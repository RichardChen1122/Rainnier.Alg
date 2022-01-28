using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode
{


    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Leetcode1609
    {
        public bool isevenoddTree(TreeNode treeNode)
        {
            if (treeNode == null)
            {
                return false;
            }

            var queue = new Queue<ValueTuple<TreeNode, int>>();

            queue.Enqueue((treeNode,0));

            int curLevel =-1;
            int previousVal=0;

            while (queue.Count > 0)
            {
                (TreeNode current, int level) = queue.Dequeue();

                //偶数层
                if (level % 2 == 0)
                {
                    if (current.val % 2 == 0)
                    {
                        return false;
                    }

                    if (level != curLevel)
                    {
                        previousVal = current.val;
                        curLevel = level;
                        continue;
                    }
                    else
                    {
                        if (current.val <= previousVal)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if (current.val % 2 != 0)
                    {
                        return false;
                    }

                    if (level != curLevel)
                    {
                        previousVal = current.val;
                        curLevel = level;
                        continue;
                    }
                    else
                    {
                        if (current.val >= previousVal)
                        {
                            return false;
                        }
                    }
                }

                if (current.left != null)
                {
                    queue.Enqueue((current.left, level + 1));
                }

                if (current.right != null)
                {
                    queue.Enqueue((current.right, level + 1));
                }
            }

            return true;
        }
    }
}
