using LeetCode.LeetCodeTop150.Matrix;
using Xunit;

namespace LeetcodeTestProject.LeetCodeTop150.Matrix;

public class RotateImageTests
{
    [Fact]
    public void Rotate_4x4Matrix_RotatesCorrectly()
    {
        var matrix = new int[][]
        {
            new[] {5, 1, 9, 11},
            new[] {2, 4, 8, 10},
            new[] {13, 3, 6, 7},
            new[] {15, 14, 12, 16}
        };

        var expected = new int[][]
        {
            new[] {15, 13, 2, 5},
            new[] {14, 3, 4, 1},
            new[] {12, 6, 8, 9},
            new[] {16, 7, 10, 11}
        };

        var solution = new RotateImage();
        solution.Rotate(matrix);

        for (int i = 0; i < matrix.Length; i++)
        {
            Assert.Equal(expected[i], matrix[i]);
        }
    }
}