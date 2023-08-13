using Rainnier.Alg.tree.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.tree
{
    public class NodeSearch
    {
        public bool NodeSearchMethod(TreeNode root, Stack<TreeNode> stack, TreeNode searchNode)
        {
            if (root == null)
            {
                return false;
            }

            //#1放这里也可以

            var left = NodeSearchMethod(root.left, stack, searchNode);
            var right = NodeSearchMethod(root.right, stack, searchNode);

            //这段代码#1放上面也可以--------------
            if (root == searchNode)
            {
                stack.Push(root);
                return true;
            }
            //-----------------------------------

            if (left || right)
            {
                stack.Push(root);
                return true;
            }
            return false;
        }

        /*Morris算法, 空间复杂度为 o(1) 的遍历算法
         * 记作当前节点为cur。

            1. 如果cur无左孩子，cur向右移动（cur=cur.right）
            2. 如果cur有左孩子，找到cur左子树上最右的节点，记为mostright
                a.如果mostright的right指针指向空，让其指向cur，cur向左移动（cur=cur.left）
                b.如果mostright的right指针指向cur，让其指向空，cur向右移动（cur=cur.right）

            实现以上的原则，即实现了morris遍历。

        总结：
        默认都是优先往左走， 往右走需要满足的两种情况之一：
        1. cur 没有左孩子 （没有左子树）
        2. cur 的左子树的最右节点的右子树是当前节点（当前节点的左子树已被完全遍历过了）

        左子树的最右边的叶子节点的右节点用来存储当前的节点，当发现该节点为空时，就让它指向cur ， 然后往左走，
        等走啊走， 再走到这个最右边的这个节点的时候， 他就指向了之前存下来的那个节点， 就回溯上去了
         * 
         * 参考 https://zhuanlan.zhihu.com/p/101321696
         */
        public void MorrisTraverse(TreeNode current)
        {
            if(current == null)
            {
                return;
            }

            while (current != null)
            {
                if (current.left == null)
                {
                    Console.WriteLine(current.val);
                    current = current.right;
                }
                else
                {
                    var mostright = FindTheMostRightNode(current);

                    if(mostright.right == null)
                    {
                        mostright.right = current;

                        Console.WriteLine(current.val);

                        current = current.left;
                    }
                    else
                    {
                        if(mostright.right == current)
                        {
                            mostright.right = null;
                            current = current.right;
                        }
                    }
                }
            }

        }

        private TreeNode FindTheMostRightNode(TreeNode root)
        {
            var current = root.left;

            while (current.right != null && current.right != root)
            {
                current = current.right;
            }

            return current;
        }
    }
}
