using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph.BreadthFirstSearchProblems;

public class ShortestPathInBinaryMatrix
{
    private List<Vector2> vectors = [
        new Vector2(1,0),
        new Vector2(0,1),
        new Vector2(1,1),
    ];

    public int ShortestPathBinaryMatrix(int[][] grid)
    {
        int n = grid.Length - 1;
        if (grid[0][0] == 1 || grid[n][n] == 1)
        {
            return -1;
        }

        Queue<(Vector2 point, int count)> points = new Queue<(Vector2 point, int count)>();
        points.Enqueue((new Vector2(0, 0), 1));

        while (points.Any())
        {
            var current = points.Dequeue();

            if(current.point.X == n && current.point.Y == n)
            {
                return current.count;
            }

            foreach (var vector in vectors)
            {
                var neighbor = current.point + vector;

                if(neighbor.X > n || neighbor.Y > n)
                {
                    continue;
                }

                var value = grid[Convert.ToInt32(neighbor.X)][Convert.ToInt32(neighbor.Y)];
                if (value == 0)
                {
                    points.Enqueue((neighbor, ++current.count));
                }
            }
        }

        return -1;
    }
}
