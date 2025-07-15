using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph.BreadthFirstSearchProblems;

public class ShortestPathInBinaryMatrix
{
    private static readonly List<(int X, int Y)> vectors = new List<(int X, int Y)>()
    {
        (1, 0),
        (0, 1),
        (1, 1),
        (-1, 0),
        (0, -1),
        (-1, -1),
        (1, -1),
        (-1, 1)
    };

    public int ShortestPathBinaryMatrix(int[][] grid)
    {
        int n = grid.Length - 1;
        if (grid[0][0] == 1 || grid[n][n] == 1)
        {
            return -1;
        }

        Queue<((int X, int Y) point, int count)> points = new Queue<((int X, int Y) point, int count)>();
        points.Enqueue(((0, 0), 1));

        while (points.Any())
        {
            var current = points.Dequeue();

            if(current.point.X == n && current.point.Y == n)
            {
                return current.count;
            }

            foreach (var vector in vectors)
            {
                var neighbor = Add(current.point, vector);

                if(neighbor.X > n || neighbor.Y > n)
                {
                    continue;
                }

                if(neighbor.X < 0 || neighbor.Y < 0)
                {
                    continue;
                }

                var value = grid[Convert.ToInt32(neighbor.X)][Convert.ToInt32(neighbor.Y)];
                if (value == 0)
                {
                    var currentCount = current.count + 1;
                    grid[neighbor.X][neighbor.Y] = 1;
                    points.Enqueue((neighbor, currentCount));
                }
            }
        }

        return -1;
    }

    private (int X, int Y) Add((int X, int Y) first, (int X, int Y) second)
    {
        return new(first.X + second.X, first.Y + second.Y);
    }
}
