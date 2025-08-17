using System.Collections.Generic;
using LeetCode.CapitalOne;
using Xunit;

namespace LeetcodeTestProject.CapitalOne;

public class DiagonalTraverseIITests
{
    [Fact]
    public void FindDiagonalOrder_ExampleInput_ReturnsExpectedOutput()
    {
        // Arrange
        var nums = new List<IList<int>>
        {
            new List<int> { 1, 2, 3 },
            new List<int> { 4, 5, 6 },
            new List<int> { 7, 8, 9 }
        };
        var expected = new[] { 1, 4, 2, 7, 5, 3, 8, 6, 9 };
        var solver = new DiagonalTraverseII();

        // Act
        var result = solver.FindDiagonalOrder(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void FindDiagonalOrder_ExampleInput2_ReturnsExpectedOutput()
    {
        // Arrange
        List<IList<int>> nums = [[1, 2, 3, 4, 5], [6, 7], [8], [9, 10, 11], [12, 13, 14, 15, 16]];
        int[] expected = [1, 6, 2, 8, 7, 3, 9, 4, 12, 10, 5, 13, 11, 14, 15, 16];
        var solver = new DiagonalTraverseII();

        // Act
        var result = solver.FindDiagonalOrder(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}