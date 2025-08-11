using LeetCode.AmazonQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTestProject.AmazonQuestionsTests;

public class CutOffTreesForGolfEventTests
{
    [Fact]
    public void CutOffTree_ExampleTestCase_ReturnsExpectedOutput()
    {
        // Arrange
        var solution = new CutOffTreesForGolfEvent();
        IList<IList<int>> forest = new List<IList<int>>
        {
            new List<int> { 1, 2, 3 },
            new List<int> { 0, 0, 4 },
            new List<int> { 7, 6, 5 }
        };
        int expected = 6;

        // Act
        int result = solution.CutOffTree(forest);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CutOffTree_NoPath_ReturnsMinusOne()
    {
        // Arrange
        var solution = new CutOffTreesForGolfEvent();
        IList<IList<int>> forest = new List<IList<int>>
        {
            new List<int> { 1, 2, 3 },
            new List<int> { 0, 0, 0 },
            new List<int> { 7, 6, 5 }
        };
        int expected = -1;

        // Act
        int result = solution.CutOffTree(forest);

        // Assert
        Assert.Equal(expected, result);
    }
}
