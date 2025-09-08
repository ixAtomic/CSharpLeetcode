using Xunit;
using LeetCode.LeetCodeTop150;

namespace LeetcodeTestProject.LeetCodeTop150Tests;

public class JumpGameIITests
{
    [Fact]
    public void Jump_ExampleInput_ReturnsExpectedOutput()
    {
        int[] nums = { 2, 3, 0, 1, 4 };
        var solution = new JumpGameII();

        int result = solution.Jump(nums);

        Assert.Equal(2, result);
    }

    [Fact]
    public void Jump_AdditionalInput_ReturnsExpectedOutput()
    {
        int[] nums = { 1, 2, 1, 1, 1 };
        var solution = new JumpGameII();

        int result = solution.Jump(nums);

        Assert.Equal(3, result);
    }
}