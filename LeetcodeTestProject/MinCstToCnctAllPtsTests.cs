using Xunit;
using LeetCode.Graph.MinimumSpanningTree;

public class MinCstToCnctAllPtsTests
{
    [Fact]
    public void MinCostConnectPoints_ExampleCase_ReturnsExpected()
    {
        var points = new int[][]
        {
            new int[] { 0, 0 },
            new int[] { 2, 2 },
            new int[] { 3, 10 },
            new int[] { 5, 2 },
            new int[] { 7, 0 }
        };

        var solver = new MinCstToCnctAllPts();
        int result = solver.MinCostConnectPoints(points);

        // Expected output for this input is 20 (LeetCode standard)
        Assert.Equal(20, result);
    }
}