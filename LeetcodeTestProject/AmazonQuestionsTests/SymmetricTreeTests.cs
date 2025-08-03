using Xunit;
using LeetCode.AmazonQuestions;

namespace LeetcodeTestProject.AmazonQuestionsTests;
public class SymmetricTreeTests
{
    [Fact]
    public void IsSymmetric_Input_1_2_2_3_4_4_3_ReturnsTrue()
    {
        // Arrange: Build the tree [1,2,2,3,4,4,3]
        var root = new TreeNode(1,
            new TreeNode(2,
                new TreeNode(3),
                new TreeNode(4)
            ),
            new TreeNode(2,
                new TreeNode(4),
                new TreeNode(3)
            )
        );
        var solver = new SymmetricTree();

        // Act
        var result = solver.IsSymmetric(root);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsSymmetric_Input_1_2_2_null_3_null_3_ReturnsFalse()
    {
        // Arrange: Build the tree [1,2,2,null,3,null,3]
        var root = new TreeNode(1,
            new TreeNode(2,
                null,
                new TreeNode(3)
            ),
            new TreeNode(2,
                null,
                new TreeNode(3)
            )
        );
        var solver = new SymmetricTree();

        // Act
        var result = solver.IsSymmetric(root);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IsSymmetric_Input_1_2_2_null_3_3_null_null_4_null_4_ReturnsFalse()
    {
        // Arrange: Build the tree [1, 2, 2, null, 3, 3, null, null, 4, null, 4]
        var root = new TreeNode(1,
            new TreeNode(2,
                null,
                new TreeNode(3, null, new TreeNode(4))
            ),
            new TreeNode(2,
                new TreeNode(3, null, new TreeNode(4)),
                null
            )
        );
        var solver = new SymmetricTree();

        // Act
        var result = solver.IsSymmetric(root);

        // Assert
        Assert.False(result);
    }
}