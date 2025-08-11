using System;
using Xunit;
using LeetCode.AmazonQuestions;

namespace LeetcodeTestProject.AmazonQuestionsTests;
public class LowestCommonAncestorOfBinaryTreeTests
{
    [Fact]
    public void LowestCommonAncestor_ReturnsRootForGivenNodes()
    {
        // Arrange
        // Tree: [3,5,1,6,2,0,8,null,null,7,4]
        var root = new TreeNode(3);
        root.left = new TreeNode(5);
        root.right = new TreeNode(1);
        root.left.left = new TreeNode(6);
        root.left.right = new TreeNode(2);
        root.right.left = new TreeNode(0);
        root.right.right = new TreeNode(8);
        root.left.right.left = new TreeNode(7);
        root.left.right.right = new TreeNode(4);

        var p = root.left; // Node with value 5
        var q = root.right; // Node with value 1

        var solution = new LowestCommonAncestorOfBinaryTree();

        // Act
        var lca = solution.LowestCommonAncestor(root, p, q);

        // Assert
        Assert.Equal(3, lca.val);
    }

    [Fact]
    public void LowestCommonAncestor_Returns5ForNodes5And4()
    {
        // Arrange
        // Tree: [3,5,1,6,2,0,8,null,null,7,4]
        var root = new TreeNode(3);
        root.left = new TreeNode(5);
        root.right = new TreeNode(1);
        root.left.left = new TreeNode(6);
        root.left.right = new TreeNode(2);
        root.right.left = new TreeNode(0);
        root.right.right = new TreeNode(8);
        root.left.right.left = new TreeNode(7);
        root.left.right.right = new TreeNode(4);

        var p = root.left; // Node with value 5
        var q = root.left.right.right; // Node with value 4

        var solution = new LowestCommonAncestorOfBinaryTree();

        // Act
        var lca = solution.LowestCommonAncestor(root, p, q);

        // Assert
        Assert.Equal(5, lca.val);
    }

    [Fact]
    public void LowestCommonAncestor_ReturnsMinus71ForNodesMinus71And8()
    {
        // Arrange
        // Tree: [37,-34,-48,null,-100,-101,48,null,null,null,null,-54,null,-71,-22,null,null,null,8]
        var nodes = new int?[] { 37, -34, -48, null, -100, -101, 48, null, null, null, null, -54, null, -71, -22, null, null, null, 8 };
        var treeNodes = new TreeNode?[nodes.Length];
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
        TreeNode p = null, q = null;
        foreach (var node in treeNodes)
        {
            if (node != null && node.val == -71) p = node;
            if (node != null && node.val == 8) q = node;
        }

        var solution = new LowestCommonAncestorOfBinaryTree();

        // Act
        var lca = solution.LowestCommonAncestor(root, p, q);

        // Assert
        Assert.Equal(-54, lca.val);
    }
}