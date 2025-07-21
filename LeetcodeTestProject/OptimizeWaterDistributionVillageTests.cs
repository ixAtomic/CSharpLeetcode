using Xunit;
using LeetCode.Graph.DisjointSetProblems;

public class OptimizeWaterDistributionInVillageTests
{
    [Fact]
    public void MinCostToSupplyWater_CustomCase_ReturnsExpected()
    {
        int n = 5;
        int[] wells = { 46012, 72474, 64965, 751, 33304 };
        int[][] pipes = new int[][]
        {
            new int[] { 2, 1, 6719 },
            new int[] { 3, 2, 75312 },
            new int[] { 5, 3, 44918 }
        };

        var solver = new OptimizeWaterDistributionInVillage();
        int result = solver.MinCostToSupplyWater(n, wells, pipes);

        Assert.Equal(131704, result);
    }

    [Fact]
    public void MinCostToSupplyWater_CustomCaseEasy_ReturnsExpected()
    {
        int n = 5;
        int[] wells = { 5, 7, 6, 1, 3 };
        int[][] pipes = new int[][]
        {
            new int[] { 2, 1, 2 },
            new int[] { 3, 2, 8 },
            new int[] { 5, 3, 4 }
        };

        var solver = new OptimizeWaterDistributionInVillage();
        int result = solver.MinCostToSupplyWater(n, wells, pipes);

        Assert.Equal(15, result);
    }
}