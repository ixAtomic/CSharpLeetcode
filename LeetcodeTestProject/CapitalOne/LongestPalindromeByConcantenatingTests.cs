using LeetCode.CapitalOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTestProject.CapitalOne;

public class LongestPalindromeByConcantenatingTests
{
    public class LongestPalindromeByConcatenatingTests
    {
        [Fact]
        public void LongestPalindrome_ReturnsExpectedResult_ForSampleInput()
        {
            // Arrange
            var solution = new LongestPalindromeByConcatenating();
            string[] words = { "lc", "cl", "gg" };
            int expected = 6; // "lc" + "gg" + "cl" or "cl" + "gg" + "lc"

            // Act
            int result = solution.LongestPalindrome(words);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
