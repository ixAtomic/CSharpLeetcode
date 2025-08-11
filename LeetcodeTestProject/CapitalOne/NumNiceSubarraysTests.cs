using Xunit;
using LeetCode.CapitalOne;

namespace LeetcodeTestProject.CapitalOne;
public class NumNiceSubarraysTests
{
    [Fact]
    public void NumberOfSubarrays_InputWithThreeOdds_ReturnsTwo()
    {
        var solution = new NumNiceSubarrays();
        int[] nums = { 1, 1, 2, 1, 1 };
        int k = 3;
        Assert.Equal(2, solution.NumberOfSubarrays(nums, k));
    }
}