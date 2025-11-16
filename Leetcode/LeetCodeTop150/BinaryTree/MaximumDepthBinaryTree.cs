using LeetCode.AmazonQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.BinaryTree;

public class MaximumDepthBinaryTree
{
    public int MaxDepth(TreeNode root)
    {
        if (root is null) return -1;
        int left = MaxDepth(root.left) + 1;
        int right = MaxDepth(root.right) + 1;
        return Math.Max(left, right);
    }
}
