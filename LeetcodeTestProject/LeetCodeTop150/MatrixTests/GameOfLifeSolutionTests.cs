using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.LeetCodeTop150.Matrix;

namespace LeetcodeTestProject.LeetCodeTop150.Matrix;

public class GameOfLifeSolutionTests
{
    [Fact]
    public void GameOfLife_Correct()
    {
        int[][] matrix = [[0, 1, 0], [0, 0, 1], [1, 1, 1], [0, 0, 0]];
        int[][] expected = [[0, 0, 0], [1, 0, 1], [0, 1, 1], [0, 1, 0]];

        var solution = new GameOfLifeSolution();
        solution.GameOfLife(matrix);

        for (int i = 0; i < matrix.Length; i++)
        {
            Assert.Equal(expected[i], matrix[i]);
        }
    }
}
