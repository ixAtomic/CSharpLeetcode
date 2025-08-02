using Xunit;
using LeetCode.AmazonQuestions;

namespace LeetcodeTestProject.AmazonQuestionsTests;
public class ValidBinarySearchTreeTests
{
    [Fact]
    public void IsValidBST_Input_2_1_3_ReturnsTrue()
    {
        // Arrange: Build the tree [2,1,3]
        var root = new TreeNode(2,
            new TreeNode(1),
            new TreeNode(3)
        );
        var validator = new ValidateBinarySearchTree();

        // Act
        var result = validator.IsValidBST(root);

        // Assert
        Assert.True(result);
    }
}