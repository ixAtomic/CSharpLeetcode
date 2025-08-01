using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph.SingleSourceShortestPath;

public class PathWithMinEffort
{
    private List<Vector2> directions = new()
    {
        new(1,0),
        new(-1,0),
        new(0,1),
        new(0,-1),
    };

    public int MinimumEffortPath(int[][] heights)
    {
        Queue<Vector2> nodes = new();
        nodes.Enqueue(new(0,0));
        var rowLen = heights[0].Length;
        int size = heights.Length * heights[0].Length;
        int[] values = Enumerable.Repeat(int.MaxValue, size).ToArray();
        bool[,] inQueue = new bool[heights.Length, heights[0].Length];
        values[0] = 0;
        inQueue[0, 0] = true;

        while (nodes.Count > 0)
        {
            var current = nodes.Dequeue();
            var X = Convert.ToInt32(current.X);
            var Y = Convert.ToInt32(current.Y);
            inQueue[X, Y] = false;
            var shortestPath = values[X * rowLen + Y];
            var currentVal = heights[X][Y];
            foreach(var direction in directions)
            {
                var neighbor = current + direction;
                var nX = Convert.ToInt32(neighbor.X);
                var nY = Convert.ToInt32(neighbor.Y);

                if(nX > heights.Length - 1 || nX < 0)
                {
                    continue;
                }

                if (nY > heights[0].Length - 1 || nY < 0)
                {
                    continue;
                }

                var cost = Math.Abs(currentVal - heights[nX][nY]);
                var mad = cost > shortestPath ? cost : shortestPath;
                if (mad < values[nX * rowLen + nY])
                {
                    values[nX * rowLen + nY] = mad;
                    if (!inQueue[nX, nY])
                    {
                        nodes.Enqueue(neighbor);
                        inQueue[nX, nY] = true;
                    }
                }
            }
        }

        return values[values.Length - 1];
    }
}
