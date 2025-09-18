using Xunit;
using LeetCode.LeetCodeTop150;
using LeetCode.LeetCodeTop150.array_string;

namespace LeetcodeTestProject.LeetCodeTop150.array_string_tests;

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

    

    [Fact]
    public void RemoveDuplicates_RemovesExtraDuplicates2_Correctly()
    {
        int[] nums = [0, 0, 1, 1, 1, 1, 2, 3, 3];
        int[] expected = [0, 0, 1, 1, 2, 3, 3];
        var solution = new RemoveDuplicatesFromSortedArrayII();

        int k = solution.RemoveDuplicates2(nums);

        Assert.Equal(7, k);
        Assert.Equal(expected, nums.Take(k));
    }
}