using LeetCode.LeetCodeTop150;
using Xunit;

namespace LeetcodeTestProject.LeetCodeTop150Tests
{
    public class IntToRomanSolutionTests
    {
        [Fact]
        public void IntToRoman_Input_3749_Returns_MMMDCCXLIX()
        {
            // Arrange
            var solution = new IntToRomanSolution();
            int num = 3749;

            // Act
            string result = solution.IntToRoman(num);

            // Assert
            Assert.Equal("MMMDCCXLIX", result);
        }
    }
}