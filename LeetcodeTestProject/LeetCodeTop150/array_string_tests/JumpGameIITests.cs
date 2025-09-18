using Xunit;
using LeetCode.LeetCodeTop150;
using LeetCode.LeetCodeTop150.array_string;

namespace LeetcodeTestProject.LeetCodeTop150.array_string_tests;

public class JumpGameIITests
{
    [Fact]
    public void Jump_ExampleInput_ReturnsExpectedOutput()
    {
        int[] nums = { 2, 3, 0, 1, 4 };
        var solution = new JumpGameII();

        int result = solution.Jump2(nums);

        Assert.Equal(2, result);
    }

    [Fact]
    public void Jump_AdditionalInput_ReturnsExpectedOutput()
    {
        int[] nums = { 1, 2, 1, 1, 1 };
        var solution = new JumpGameII();

        int result = solution.Jump2(nums);

        Assert.Equal(3, result);
    }
}