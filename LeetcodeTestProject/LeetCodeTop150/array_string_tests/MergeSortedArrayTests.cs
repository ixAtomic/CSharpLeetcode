using Xunit;
using LeetCode.LeetCodeTop150;
using LeetCode.LeetCodeTop150.array_string;

namespace LeetcodeTestProject.LeetCodeTop150.array_string_tests;

public class MergeSortedArrayTests
{
    [Fact]
    public void Merge_Case1_MergesCorrectly()
    {
        int[] nums1 = { 4, 5, 6, 0, 0, 0 };
        int[] nums2 = { 1, 2, 3 };
        int[] expected = { 1, 2, 3, 4, 5, 6 };
        var solution = new MergeSortedArray();

        solution.MergeSecond(nums1, 3, nums2, 3);

        Assert.Equal(expected, nums1);
    }

    [Fact]
    public void Merge_Case2_MergesCorrectly()
    {
        int[] nums1 = { 1, 2, 3, 0, 0, 0 };
        int[] nums2 = { 4, 5, 6 };
        int[] expected = { 1, 2, 3, 4, 5, 6 };
        var solution = new MergeSortedArray();

        solution.Merge(nums1, 3, nums2, 3);

        Assert.Equal(expected, nums1);
    }

    [Fact]
    public void Merge_Case3_MergesCorrectly()
    {
        int[] nums1 = { 1, 2, 2, 0, 0, 0 };
        int[] nums2 = { 3, 5, 6 };
        int[] expected = { 1, 2, 2, 3, 5, 6 };
        var solution = new MergeSortedArray();

        solution.Merge(nums1, 3, nums2, 3);

        Assert.Equal(expected, nums1);
    }

    [Fact]
    public void Merge_Case4_MergesCorrectly()
    {
        int[] nums1 = { 1 };
        int[] nums2 = { };
        int[] expected = { 1 };
        var solution = new MergeSortedArray();

        solution.Merge(nums1, 1, nums2, 0);

        Assert.Equal(expected, nums1);
    }
}