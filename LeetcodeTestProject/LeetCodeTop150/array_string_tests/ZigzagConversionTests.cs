using LeetCode.LeetCodeTop150;
using LeetCode.LeetCodeTop150.array_string;
using Xunit;

namespace LeetcodeTestProject.LeetCodeTop150.array_string_tests;

public class ZigzagConversionTests
{
    [Fact]
    public void Convert_Input_PAYPALISHIRING_NumRows_3_Returns_PAHNAPLSIIGYIR()
    {
        // Arrange
        var solution = new ZigzagConversion();
        string s = "PAYPALISHIRING";
        int numRows = 3;

        // Act
        string result = solution.Convert(s, numRows);

        // Assert
        Assert.Equal("PAHNAPLSIIGYIR", result);
    }
}