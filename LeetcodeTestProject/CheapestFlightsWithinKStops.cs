using Xunit;
using LeetCode.Graph.SingleSourceShortestPath;

public class CheapestFlightsWithinKStopsTests
{
    [Fact]
    public void FindCheapestPrice_CustomCase_ReturnsExpected()
    {
        int n = 4;
        int[][] flights = new int[][]
        {
            new int[] { 0, 1, 100 },
            new int[] { 1, 2, 100 },
            new int[] { 2, 0, 100 },
            new int[] { 1, 3, 600 },
            new int[] { 2, 3, 200 }
        };
        int src = 0;
        int dst = 3;
        int k = 1;

        var solver = new CheapestFlightsWithinKStops();
        int result = solver.FindCheapestPrice(n, flights, src, dst, k);

        Assert.Equal(700, result);
    }

    [Fact]
    public void FindCheapestPrice_SecondCase_ReturnsExpected()
    {
        int n = 5;
        int[][] flights = new int[][]
        {
            new int[] { 1, 0, 5 },
            new int[] { 2, 1, 5 },
            new int[] { 3, 0, 2 },
            new int[] { 1, 3, 2 },
            new int[] { 4, 1, 1 },
            new int[] { 2, 4, 1 }
        };
        int src = 2;
        int dst = 0;
        int k = 2;

        var solver = new CheapestFlightsWithinKStops();
        int result = solver.FindCheapestPrice(n, flights, src, dst, k);

        Assert.Equal(7, result);
    }
}