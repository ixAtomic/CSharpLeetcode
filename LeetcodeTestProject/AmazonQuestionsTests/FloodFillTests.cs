using LeetCode.AmazonQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTestProject.AmazonQuestionsTests;

public class FloodFillTests
{
    [Fact]
    public void FloodFill_ExampleTestCase_ReturnsExpectedOutput()
    {
        // Arrange
        var solution = new FloodFillSolution();
        int[][] image = new int[][]
        {
            new int[] { 1, 1, 1 },
            new int[] { 1, 1, 0 },
            new int[] { 1, 0, 1 }
        };
        int sr = 1, sc = 1, color = 2;

        int[][] expected = new int[][]
        {
            new int[] { 2, 2, 2 },
            new int[] { 2, 2, 0 },
            new int[] { 2, 0, 1 }
        };

        // Act
        var result = solution.FloodFill(image, sr, sc, color);

        // Assert
        for (int i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expected[i], result[i]);
        }
    }
}
