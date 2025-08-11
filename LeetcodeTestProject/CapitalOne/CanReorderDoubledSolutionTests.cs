using Xunit;
using LeetCode.CapitalOne;

namespace LeetcodeTestProject.CapitalOne;

public class CanReorderDoubledSolutionTests
{
    [Fact]
    public void CanReorderDoubled_InputWithNegativesAndPositives_ReturnsTrue()
    {
        var solution = new CanReorderDoubledSol();
        int[] arr = { 4, -2, 2, -4 };
        Assert.True(solution.CanReorderDoubled(arr));
    }

    [Fact]
    public void CanReorderDoubled_InputWithZeroes_ReturnsTrue()
    {
        var solution = new CanReorderDoubledSol();
        int[] arr = [2, 4, 0, 0, 8, 1];
        Assert.True(solution.CanReorderDoubled(arr));
    }
}