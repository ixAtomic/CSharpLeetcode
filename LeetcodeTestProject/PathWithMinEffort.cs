using System;
using Xunit;
using LeetCode.Graph.SingleSourceShortestPath;

namespace LeetcodeTestProject;

public class PathWithMinEffortTests
{
    [Fact]
    public void MinimumEffortPath_ReturnsExpectedResult()
    {
        // Arrange
        var solution = new PathWithMinEffort();
        int[][] heights = new int[][]
        {
            new int[] { 1, 2, 2 },
            new int[] { 3, 8, 2 },
            new int[] { 5, 3, 5 }
        };

        // Act
        int result = solution.MinimumEffortPath(heights);

        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void MinimumEffortPath2_ReturnsExpectedResult()
    {
        // Arrange
        var solution = new PathWithMinEffort();
        int[][] heights = new int[][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 3, 8, 4 },
            new int[] { 5, 3, 5 }
        };

        // Act
        int result = solution.MinimumEffortPath(heights);

        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void MinimumEffortPath3_ReturnsExpectedResult()
    {
        // Arrange
        var solution = new PathWithMinEffort();
        int[][] heights = [
            [1, 2, 1, 1, 1],
            [1, 2, 1, 2, 1],
            [1, 2, 1, 2, 1],
            [1, 2, 1, 2, 1],
            [1, 1, 1, 2, 1]
        ];

        // Act
        int result = solution.MinimumEffortPath(heights);

        // Assert
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void MinimumEffortPath4_ReturnsExpectedResult()
    {
        // Arrange
        var solution = new PathWithMinEffort();
        int[][] heights = [
            [1, 10, 6, 7, 9, 10, 4, 9]
        ];

        // Act
        int result = solution.MinimumEffortPath(heights);

        // Assert
        Assert.Equal(9, result);
    }
}