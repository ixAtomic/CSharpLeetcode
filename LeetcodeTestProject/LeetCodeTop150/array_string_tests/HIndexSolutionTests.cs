using LeetCode.LeetCodeTop150;
using LeetCode.LeetCodeTop150.array_string;
using Xunit;

namespace LeetcodeTestProject.LeetCodeTop150.array_string_tests;

public class HIndexSolutionTests
{
    [Fact]
    public void HIndex_Input_3_0_6_1_5_Returns_3()
    {
        // Arrange
        var solution = new HIndexSolution();
        int[] citations = { 3, 0, 6, 1, 5 };

        // Act
        int result = solution.HIndex(citations);

        // Assert
        Assert.Equal(3, result);
    }
}