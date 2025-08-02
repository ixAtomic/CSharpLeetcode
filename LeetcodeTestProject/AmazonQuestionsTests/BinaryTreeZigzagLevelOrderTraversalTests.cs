using Xunit;
using LeetCode.AmazonQuestions;

namespace LeetcodeTestProject.AmazonQuestionsTests;

public class BinaryTreeZigzagLevelOrderTraversalTests
{
    [Fact]
    public void ZigzagLevelOrder_InputExample_ReturnsExpected()
    {
        // Arrange: Build the tree [3,9,20,null,null,15,7]
        var root = new TreeNode(3,
            new TreeNode(9),
            new TreeNode(20,
                new TreeNode(15),
                new TreeNode(7)
            )
        );
        var solver = new BinaryTreeZigzagLevelOrderTraversal();

        // Act
        var result = solver.ZigzagLevelOrder(root);

        // Assert
        var expected = new List<IList<int>>
        {
            new List<int> { 3 },
            new List<int> { 20, 9 },
            new List<int> { 15, 7 }
        };
        Assert.Equal(expected.Count, result.Count);
        for (int i = 0; i < expected.Count; i++)
        {
            Assert.Equal(expected[i], result[i]);
        }
    }

    [Fact]
    public void ZigzagLevelOrder_Input_1_2_3_4_null_null_5_ReturnsExpected()
    {
        // Arrange: Build the tree [1,2,3,4,null,null,5]
        var root = new TreeNode(1,
            new TreeNode(2,
                new TreeNode(4),
                null
            ),
            new TreeNode(3,
                null,
                new TreeNode(5)
            )
        );
        var solver = new BinaryTreeZigzagLevelOrderTraversal();

        // Act
        var result = solver.ZigzagLevelOrder(root);

        // Assert
        var expected = new List<IList<int>>
        {
            new List<int> { 1 },
            new List<int> { 3, 2 },
            new List<int> { 4, 5 }
        };
        Assert.Equal(expected.Count, result.Count);
        for (int i = 0; i < expected.Count; i++)
        {
            Assert.Equal(expected[i], result[i]);
        }
    }
}