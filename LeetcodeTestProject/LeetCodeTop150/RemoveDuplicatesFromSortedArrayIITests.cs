using Xunit;
using LeetCode.LeetCodeTop150;

namespace LeetcodeTestProject.LeetCodeTop150Tests;

public class RemoveDuplicatesFromSortedArrayIITests
{
    [Fact]
    public void RemoveDuplicates_RemovesExtraDuplicates_Correctly()
    {
        int[] nums = { 1, 1, 1, 2, 2, 2, 3, 3 };
        int[] expected = { 1, 1, 2, 2, 3, 3 };
        var solution = new RemoveDuplicatesFromSortedArrayII();

        int k = solution.RemoveDuplicates(nums);

        Assert.Equal(6, k);
        Assert.Equal(expected, nums.Take(k));
    }
}