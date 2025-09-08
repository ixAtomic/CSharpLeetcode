using Xunit;
using LeetCode.Agoda;

namespace LeetcodeTestProject.Agoda;

public class UniquePathsIITests
{
    [Fact]
    public void UniquePathsWithObstacles_ExampleInput_ReturnsExpectedOutput()
    {
        // Arrange
        int[][] obstacleGrid = new int[][]
        {
            new int[] { 0, 0, 0 },
            new int[] { 0, 1, 0 },
            new int[] { 0, 0, 0 }
        };
        var solver = new UniquePathsII();

        // Act
        int result = solver.UniquePathsWithObstacles(obstacleGrid);

        // Assert
        Assert.Equal(2, result);
    }
}