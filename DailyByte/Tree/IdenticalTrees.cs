using System;
using System.Collections.Generic;
using System.Text;

namespace DailyByte.Tree
{
    public class IdenticalTrees
    {
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            return Helper(p, q);
        }

        public static bool Helper(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;

            if (p == null || q == null)
                return false;

            if (p.val != q.val)
                return false;

            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}
