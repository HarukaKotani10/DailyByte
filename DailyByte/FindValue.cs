using System;
using System.Collections.Generic;
using System.Text;

namespace DailyByte
{
    public class FindValue
    {
        public static TreeNode SearchBST(TreeNode root, int val)
        {

            if (root == null || root.val == val)
                return root;

            if (root.val > val)
                return SearchBST(root.left, val);

            else
                return SearchBST(root.right, val);
        }
    }
}
