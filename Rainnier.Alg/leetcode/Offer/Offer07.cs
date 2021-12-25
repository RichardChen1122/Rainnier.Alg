using Rainnier.Alg.memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainnier.Alg.leetcode.Offer
{
    internal class Offer07
    {
        //Input: preorder = [3,9,20,15,7], inorder = [9,3,15,20,7]
        //Output: [3,9,20,null,null,15,7]



        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }


        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if(preorder == null || inorder == null || preorder.Length==0 || inorder.Length == 0)
            {
                return null;
            }

            var root = new TreeNode(preorder[0]);

            FindRootAndBuildChild(preorder,inorder, root, 0, preorder.Length-1, 0);

            return root;

            
        }

        private void FindRootAndBuildChild(int[] preorder, int[] inorder, TreeNode root, int preStart, int preEnd, int inStart)
        {
            if(root == null || preStart==preEnd)
            {
                return;
            }
            int index = inStart;
            while(inorder[index] != root.val)
            {
                index++;
            }

            var gap = index - inStart;

            if (gap > 0) {

                root.left = new TreeNode(preorder[preStart+1]);
            }
            else
            {
                root.left = null;
            }

            if (preStart + gap + 1 <= preEnd)
            {
                root.right = new TreeNode(preorder[preStart + gap + 1]);
            }
            else
            {
                root.right = null;
            }

            FindRootAndBuildChild(preorder, inorder, root.left, preStart + 1, preStart+ gap, inStart);
            FindRootAndBuildChild(preorder, inorder, root.right, preStart + gap+ 1, preEnd, index+1);
        }
    }
}
