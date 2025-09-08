using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Agoda;

//this is Dynamic Programming and idk how to do it :)
public class UniquePathsII
{
    private readonly List<Point> directions =
    [
        new(1,0),
        new(0,1)
    ];

    private record Point(int x, int y);
    private Point endPoint;

    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        endPoint = new(obstacleGrid.Length - 1, obstacleGrid[0].Length - 1);

        if (obstacleGrid[0][0] == 1)
        {
            return 0;
        }

        if (obstacleGrid[endPoint.x][endPoint.y] == 1)
        {
            return 0;
        }

        Point current = new(0, 0);
        return dfs(current, obstacleGrid);
    }

    private int dfs(Point current, int[][] obstacleGrid)
    {
        if(current == endPoint)
        {
            return 1;
        }

        int result = 0;
        foreach(Point direction in directions)
        {
            Point neighbor = new(current.x + direction.x, current.y + direction.y);

            if (neighbor.x < 0) continue;

            if (neighbor.y < 0) continue;

            if (neighbor.x >= obstacleGrid.Length) continue;

            if(neighbor.y >= obstacleGrid[0].Length) continue;

            if (obstacleGrid[neighbor.x][neighbor.y] == 1) continue;

            obstacleGrid[neighbor.x][neighbor.y] = 1;

            result += dfs(neighbor, obstacleGrid);

            obstacleGrid[neighbor.x][neighbor.y] = 0;
        }

        return result;
    }
}
