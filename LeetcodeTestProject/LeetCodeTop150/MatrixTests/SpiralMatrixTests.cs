using Xunit;
using LeetCode.LeetCodeTop150.Matrix;
using System.Collections.Generic;

namespace LeetcodeTestProject.LeetCodeTop150.Matrix;

public class SpiralMatrixTests
{
    [Fact]
    public void SpiralOrder_3x3Matrix_ReturnsCorrectOrder()
    {
        var matrix = new int[][]
        {
            new[] {1, 2, 3},
            new[] {4, 5, 6},
            new[] {7, 8, 9}
        };

        var solution = new SpiralMatrix();
        var result = solution.SpiralOrder(matrix);

        var expected = new List<int> { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SpiralOrder_3x4Matrix_ReturnsCorrectOrder()
    {
        var matrix = new int[][]
        {
            new[] {1, 2, 3, 4},
            new[] {5, 6, 7, 8},
            new[] {9, 10, 11, 12}
        };

        var solution = new SpiralMatrix();
        var result = solution.SpiralOrder(matrix);

        var expected = new List<int> { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 };
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SpiralOrder_2x1Matrix_ReturnsCorrectOrder()
    {
        var matrix = new int[][]
        {
            new[] {3},
            new[] {2}
        };

        var solution = new SpiralMatrix();
        var result = solution.SpiralOrder(matrix);

        var expected = new List<int> { 3, 2 };
        Assert.Equal(expected, result);
    }
}