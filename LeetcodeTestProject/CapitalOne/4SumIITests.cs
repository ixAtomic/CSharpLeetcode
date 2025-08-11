using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using LeetCode.CapitalOne;

namespace LeetcodeTestProject.CapitalOne;

public class _4SumIITests
{
    [Fact]
    public void FourSumCount_ReturnsExpectedResult_ForSampleInput()
    {
        // Arrange
        var solution = new _4SumII();
        int[] nums1 = { 1, 2 };
        int[] nums2 = { -2, -1 };
        int[] nums3 = { -1, 2 };
        int[] nums4 = { 0, 2 };
        int expected = 2;

        // Act
        int result = solution.FourSumCount(nums1, nums2, nums3, nums4);

        // Assert
        Assert.Equal(expected, result);
    }
}
