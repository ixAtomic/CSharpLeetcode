using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph.MinimumSpanningTree;

public class MinCstToCnctAllPts
{
    public int MinCostConnectPoints(int[][] points)
    {
        if(points == null || points.Length == 0) return 0;

        PriorityQueue<(int from, int to, int distance), int> edges = new PriorityQueue<(int from, int to, int distance), int>();

        var edgeSize = points.Length - 1;
        DisjointSet DS = new DisjointSet(points.Length);
        for (int i = 0; i < points.Length; i++) 
        {
            var xi = points[i][0];
            var yi = points[i][1];

            for (int j = i + 1; j < points.Length; j++) 
            { 
                var xj = points[j][0];
                var yj = points[j][1];

                var x = Convert.ToInt32(Math.Abs(xi - xj));
                var y = Convert.ToInt32(Math.Abs(yi - yj));

                var distance = x + y;

                edges.Enqueue((i, j, distance), distance);
            }
        }

        var total = 0;
        while (edges.Count > 0 && edgeSize > 0) 
        {
            var current = edges.Dequeue();

            if(!DS.IsConnected(current.from, current.to))
            {
                DS.Union(current.from, current.to);
                total += current.distance;
                edgeSize--;
            }
        }

        return total;
    }
}
