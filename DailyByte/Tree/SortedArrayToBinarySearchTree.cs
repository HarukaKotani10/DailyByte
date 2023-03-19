using System;
using System.Collections.Generic;
using System.Text;

namespace DailyByte.Tree
{
    public class SortedArrayToBinarySearchTree
    {
        public static TreeNode ConvertArrayToBST(int [] nums)
        {
            return Helper(nums, 0, nums.Length - 1);
        }

        public static TreeNode Helper(int [] nums, int start, int end)
        {
            if (start > end)
                return null;

            int mid = (start + end) / 2;
            TreeNode node = new TreeNode(nums[mid]);

            node.left = Helper(nums, 0, mid - 1);
            node.right = Helper(nums, mid + 1, end);

            return node;
        }
    }
}
