using Rainnier.Alg.tree.model;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
