using LeetcodeTestProject.LeetCodeTop150;
using Xunit;

namespace LeetcodeTestProject.LeetCodeTop150.array_string_tests
{
    public class TrappingRainWaterTests
    {
        [Fact]
        public void Trap_Input_0_1_0_2_1_0_1_3_2_1_2_1_Returns_6()
        {
            // Arrange
            var solution = new TrappingRainWater();
            int[] height = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

            // Act
            int result = solution.Trap(height);

            // Assert
            Assert.Equal(6, result);
        }
    }
}