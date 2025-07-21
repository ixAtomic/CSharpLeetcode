using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph.MinimumSpanningTree.PrimsAlgorithm;

public class MinCstToCnctAllPts
{
    public int MinCostConnectPoints(int[][] points)
    {
        if (points == null || points.Length == 0) return 0;

        int n = points.Length;
        PriorityQueue<Edge, int> q = new PriorityQueue<Edge, int>();
        List<bool> visited = Enumerable.Repeat(false, n).ToList();

        int result = 0;
        int count = n - 1;

        var first = points[0];
        for(int i = 0; i < n; i++)
        {
            var xj = points[i][0];
            var yj = points[i][1];

            var x = Convert.ToInt32(Math.Abs(first[0] - xj));
            var y = Convert.ToInt32(Math.Abs(first[1] - yj));

            var distance = x + y;

            q.Enqueue(new Edge(0, i, distance), distance);
        }
        visited[0] = true;

        while(q.Count > 0 && count > 0)
        {
            var edge = q.Dequeue();
            int from = edge.From;
            int to = edge.To;
            int cost = edge.Cost;

            if (!visited[to])
            {
                result += cost;
                visited[to] = true;
                for (int j = 0; j < n; j++)
                {
                    if (!visited[j])
                    {
                        var xj = points[j][0];
                        var yj = points[j][1];

                        var x = Math.Abs(points[to][0] - points[j][0]);
                        var y = Math.Abs(points[to][1] - points[j][1]);
                        var distance = x + y;
                        q.Enqueue(new Edge(to, j, distance), distance);
                    }
                }
                count--;
            }
        }
        return result;
    }

    private record Edge(int From, int To, int Cost);
}


