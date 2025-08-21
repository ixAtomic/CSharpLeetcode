using Xunit;
using LeetCode.CapitalOne.Q3;

namespace LeetcodeTestProject.Q3.CapitalOne;

public class ReshapeTheMatrixTests
{
    [Fact]
    public void MatrixReshape_ExampleInput_ReturnsExpectedOutput()
    {
        // Arrange
        int[][] mat = new int[][]
        {
            new int[] { 1, 2 },
            new int[] { 3, 4 }
        };
        int r = 1, c = 4;
        var solver = new ReshapeTheMatrix();
        int[][] expected = new int[][]
        {
            new int[] { 1, 2, 3, 4 }
        };

        // Act
        int[][] result = solver.MatrixReshape(mat, r, c);

        // Assert
        Assert.Equal(expected.Length, result.Length);
        for (int i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expected[i], result[i]);
        }
    }
}