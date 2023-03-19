using System;
using System.Collections.Generic;
using System.Text;

namespace DailyByte.Tree
{
    public class LowestCommonAncestor
    {
        //Given a binary search tree that contains unique values and two nodes within the tree, a, and b, return their lowest common ancestor.
        //Note: the lowest common ancestor of two nodes is the deepest node within the tree such that both nodes are descendants of it.
        public static TreeNode GetLowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
            {
                return null;  // base case: reached the end of a subtree without finding p or q
            }

            if (p.val < root.val && q.val < root.val)
            {
                return GetLowestCommonAncestor(root.left, p, q);  // search the left subtree
            }

            if (p.val > root.val && q.val > root.val)
            {
                return GetLowestCommonAncestor(root.right, p, q);  // search the right subtree
            }

            return root;  // root is the LCA because p and q are on different sides of it
        }
    }
}
