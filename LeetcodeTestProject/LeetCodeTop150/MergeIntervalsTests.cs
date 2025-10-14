using LeetCode.LeetCodeTop150.Intervals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTestProject.LeetCodeTop150.Ranges;

public class MergeIntervalsTests
{
    [Fact]
    public void Valid_MergeIntervals()
    {
        // Arrange
        int[][] intervals = new int[][]
        {
            new int[] { 1, 3 },
            new int[] { 2, 6 },
            new int[] { 8, 10 },
            new int[] { 15, 18 }
        };

        int[][] expected = new int[][]
        {
            new int[] { 1, 6 },
            new int[] { 8, 10 },
            new int[] { 15, 18 }
        };

        var solver = new MergeIntervals();

        // Act
        var result = solver.Merge(intervals);

        // Assert
        Assert.Equal(expected.Length, result.Length);

        for (int i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expected[i][0], result[i][0]);
            Assert.Equal(expected[i][1], result[i][1]);
        }
    }
}
