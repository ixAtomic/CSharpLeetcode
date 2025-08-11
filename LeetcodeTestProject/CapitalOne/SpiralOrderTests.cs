using System.Collections.Generic;
using Xunit;
using LeetCode.CapitalOne;

namespace LeetcodeTestProject.CapitalOne
{
    public class SpiralOrderTests
    {
        [Fact]
        public void SpiralOrder_ReturnsExpectedResult_For3x3Matrix()
        {
            // Arrange
            var solution = new SpiralOrderSolution();
            int[][] matrix = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };
            var expected = new List<int> { 1, 2, 3, 6, 9, 8, 7, 4, 5 };

            // Act
            var result = solution.SpiralOrder(matrix);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SpiralOrder_ReturnsExpectedResult_2Matrix()
        {
            // Arrange
            var solution = new SpiralOrderSolution();
            int[][] matrix = [
                [1,2,3,4],
                [5,6,7,8],
                [9,10,11,12],
                [13,14,15,16],
                [17,18,19,20],
                [21,22,23,24]
            ];

            List<int> expected = [1, 2, 3, 4, 8, 12, 16, 20, 24, 23, 22, 21, 17, 13, 9, 5, 6, 7, 11, 15, 19, 18, 14, 10];

            // Act
            var result = solution.SpiralOrder(matrix);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}