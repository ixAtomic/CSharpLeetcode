using Xunit;
using LeetCode.CapitalOneRelatedQuestions;

namespace LeetcodeTestProject.CapitalOneRelatedQuestions;

public class WaysToSplitArrayIntoGoodSubarraysTests
{
    [Fact]
    public void NumberOfGoodSubarraySplits_ReturnsExpected_ForSampleInput()
    {
        var solver = new WaysToSplitArrayIntoGoodSubarrays();
        int[] nums = { 0, 1, 0, 0, 1 };
        int expected = 3;

        int result = solver.NumberOfGoodSubarraySplits(nums);

        Assert.Equal(expected, result);
    }
}
