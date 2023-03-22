using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DailyByte.Tree
{
    public class MinimumDifference
    {
        public static int GetMiniDif(TreeNode root)
        {
            int min = int.MaxValue;
            int prev = int.MinValue;

             GetMin(root, ref min, ref prev);

            return min;
        }

        public static void GetMin(TreeNode node, ref int min, ref int prev)
        {
            if (node == null)
                return;

            GetMin(node.left, ref min, ref prev);

            if(prev != int.MinValue)
            {
                int diff = node.val - prev;
                if (diff < min)
                    min = diff;
            }

            prev = node.val;
            GetMin(node.right, ref min, ref prev);    
            
        }
    }
}
