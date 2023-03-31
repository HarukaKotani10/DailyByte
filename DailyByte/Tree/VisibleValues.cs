using System;
using System.Collections.Generic;
using System.Text;

namespace DailyByte.Tree
{
    class VisibleValues
    {
        public List<int> GetFisibleValues(TreeNode root)
        {
            var result = new List<int>();

            if (root == null)
                return result;

            var q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                int size = q.Count;    
                result.Add(q.Peek().val);

                for(int i=0; i < size; i++)
                {
                    var node = q.Dequeue();
                    if (node.left != null)
                        q.Enqueue(node.left);
                    if (node.right != null)
                        q.Enqueue(node.right);
                }    
            }

            return result;
        }
    }
}
