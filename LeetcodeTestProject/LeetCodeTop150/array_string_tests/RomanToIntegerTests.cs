using LeetCode.LeetCodeTop150;
using LeetCode.LeetCodeTop150.array_string;
using Xunit;

namespace LeetcodeTestProject.LeetCodeTop150.array_string_tests
{
    public class RomanToIntegerTests
    {
        [Fact]
        public void RomanToInt_Input_MCMXCIV_Returns_1994()
        {
            // Arrange
            var solution = new RomanToInteger();
            string roman = "MCMXCIV";

            // Act
            int result = solution.RomanToInt(roman);

            // Assert
            Assert.Equal(1994, result);
        }
    }
}