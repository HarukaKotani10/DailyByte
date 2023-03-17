using System;
using System.Collections.Generic;
using System.Text;

namespace DailyByte
{
    public class ConvertBinarySearchTreeToSortedLinkedList<T>
    {
        public static LinkedList<TreeNode> ConvertTree(TreeNode root)
        {
            LinkedList<TreeNode> sortedList = new LinkedList<TreeNode>();
            ConvertTreeHelper(root, sortedList);
            return sortedList;
        }

        private static void ConvertTreeHelper(TreeNode node, LinkedList<TreeNode> list)
        {
            if (node == null)
                return;

            ConvertTreeHelper(node.left, list);
            list.AddLast(node);
            ConvertTreeHelper(node.right, list);
        }
    }
}
