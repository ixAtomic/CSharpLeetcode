using Xunit;
using LeetCode.LeetCodeTop150.SlidingWindow;

namespace LeetcodeTestProject.LeetCodeTop150.SlidingWindow_tests;

public class MinimumWindowSubstringTests
{
    [Fact]
    public void MinWindow_ReturnsExpectedResult()
    {
        // Arrange
        var solution = new MinimumWindowSubstring();
        string s = "ADOBECODEBANC";
        string t = "ABC";

        // Act
        string result = solution.MinWindow(s, t);

        // Assert
        Assert.Equal("BANC", result);
    }
}