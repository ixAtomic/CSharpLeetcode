using System;
using Xunit;
using LeetCode.AmazonQuestions;

namespace LeetcodeTestProject.AmazonQuestionsTests;

public class DiameterOfBinaryTreeTests
{
    [Fact]
    public void DiameterOfBinaryTree_Returns3_ForSampleTree()
    {
        // Arrange
        // Tree: [1,2,3,4,5]
        //      1
        //     / \
        //    2   3
        //   / \
        //  4   5
        var root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.left.left = new TreeNode(4);
        root.left.right = new TreeNode(5);

        var solution = new DiameterOfBinaryTreeSolution();

        // Act
        int diameter = solution.DiameterOfBinaryTree(root);

        // Assert
        Assert.Equal(3, diameter);
    }

    [Fact]
    public void DiameterOfBinaryTree_ReturnsExpected_ForComplexTree()
    {
        // Arrange
        // Tree: [4,-7,-3,null,null,-9,-3,9,-7,-4,null,6,null,-6,-6,null,null,0,6,5,null,9,null,null,-1,-4,null,null,null,-2]
        int?[] nodes = new int?[] { 4, -7, -3, null, null, -9, -3, 9, -7, -4, null, 6, null, -6, -6, null, null, 0, 6, 5, null, 9, null, null, -1, -4, null, null, null, -2 };
        TreeNode[] treeNodes = new TreeNode[nodes.Length];
        for (int i = 0; i < nodes.Length; i++)
        {
            if (nodes[i].HasValue)
                treeNodes[i] = new TreeNode(nodes[i].Value);
        }
        for (int i = 0, j = 1; j < nodes.Length; i++)
        {
            if (treeNodes[i] == null) continue;
            if (j < nodes.Length) treeNodes[i].left = treeNodes[j++];
            if (j < nodes.Length) treeNodes[i].right = treeNodes[j++];
        }
        var root = treeNodes[0];

        var solution = new DiameterOfBinaryTreeSolution();

        // Act
        int diameter = solution.DiameterOfBinaryTree(root);

        // Assert
        // The expected diameter for this tree is 8 (longest path between two nodes)
        Assert.Equal(8, diameter);
    }
}