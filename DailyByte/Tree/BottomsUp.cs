using System;
using System.Collections.Generic;
using System.Text;

namespace DailyByte.Tree
{
    class BottomsUp
    {
        public List<List<int>> GetBottomsUp(TreeNode root)
        {
            var result = new List<List<int>>();
            var tempQueue = new Queue<TreeNode>();

            if (root == null)
                return result;
            
            tempQueue.Enqueue(root);

            while(tempQueue.Count > 0)
            {
                int size = tempQueue.Count;
                var tempList = new List<int>();

                for (int i=0; i < size; i++)
                {
                    TreeNode node = tempQueue.Dequeue();
                    tempList.Add(node.val);

                    if (node.left != null)
                        tempQueue.Enqueue(node.left);

                    if (node.right != null)
                        tempQueue.Enqueue(node.right);
                }

                result.Insert(0, tempList);
            }

            return result;
        }
    }
}
