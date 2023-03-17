using DailyByte;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DailyByteTest
{
    public class FindValueTest
    {
        [Fact]
        public void TestSearchBST()
        {
            TreeNode root = new TreeNode(4);
            root.left = new TreeNode(2);
            root.right = new TreeNode(7);
            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(3);

            // Test case 1: Search for existing value
            TreeNode node = FindValue.SearchBST(root, 2);
            Assert.Equal(2, node.val);
            Assert.Equal(1, node.left.val);
            Assert.Equal(3, node.right.val);

            // Test case 2: Search for non-existing value
            node = FindValue.SearchBST(root, 5);
            Assert.Equal(null, node);
        }

        [Fact]
        public void TestConvertTree()
        {
            // Create a binary search tree
            TreeNode tree = new TreeNode(4);
            tree.left = new TreeNode(2);
            tree.left.left = new TreeNode(1);
            tree.left.right = new TreeNode(3);
            tree.right = new TreeNode(6);
            tree.right.left = new TreeNode(5);
            tree.right.right = new TreeNode(7);

            // Convert the tree to a linked list
            LinkedList<TreeNode> sortedList = ConvertBinarySearchTreeToSortedLinkedList<int>.ConvertTree(tree);

            // Check if the linked list is sorted in ascending order
            LinkedListNode<TreeNode> node = sortedList.First;
            while (node.Next != null)
            {
                Assert.True(node.Value.val < node.Next.Value.val);
                node = node.Next;
            }
        }
    }
}
