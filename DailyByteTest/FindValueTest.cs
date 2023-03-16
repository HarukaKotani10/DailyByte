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
    }
}
