using System;
using Xunit;
using LeetCode.CapitalOne.Q3;

namespace LeetcodeTestProject.Q3.CapitalOne;
public class ToeplitzMatrixTests
{
    [Fact]
    public void IsToeplitzMatrix_ExampleInput_ReturnsTrue()
    {
        // Arrange
        int[][] matrix = new int[][]
        {
            new int[] { 1, 2, 3, 4 },
            new int[] { 5, 1, 2, 3 },
            new int[] { 9, 5, 1, 2 }
        };
        var solver = new ToeplitzMatrix();

        // Act
        bool result = solver.IsToeplitzMatrix(matrix);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsToeplitzMatrix_ExampleInputFirstFail_ReturnsTrue()
    {
        // Arrange
        int[][] matrix = [[0, 33, 98], [34, 22, 33]];
        var solver = new ToeplitzMatrix();

        // Act
        bool result = solver.IsToeplitzMatrix(matrix);

        // Assert
        Assert.True(result);
    }
}