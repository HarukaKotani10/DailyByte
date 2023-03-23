using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyByte.Tree
{
    public class FindModeInBST
    {
        public int FindMode(TreeNode root)
        {
            Dictionary<int, int> myDict = new Dictionary<int, int>();
            if (root == null)
                return -1;

            Helper(myDict, root);
            int maxVal = myDict.Values.Max();

            foreach(int i in myDict.Keys)
            {
                if (myDict[i] == maxVal)
                    return i;
            }

            return -1;
        }

        public void Helper(Dictionary<int, int> myDict, TreeNode root)
        {
            if (root == null)
                return;

            Helper(myDict, root.left);

            if (myDict.ContainsKey(root.val))
                myDict[root.val] = myDict[root.val] + 1;

            else
                myDict.Add(root.val, 1);

            Helper(myDict, root.right);
        }
    }
}
