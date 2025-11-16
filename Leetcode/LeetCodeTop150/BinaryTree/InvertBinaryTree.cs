using LeetCode.AmazonQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.BinaryTree;

public class InvertBinaryTree
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root is null) return null;
        if (root.left is null && root.right is null) return root;

        TreeNode left = InvertTree(root.left);
        TreeNode right = InvertTree(root.right);

        root.left = right;
        root.right = left;
        return root;
    }
}
