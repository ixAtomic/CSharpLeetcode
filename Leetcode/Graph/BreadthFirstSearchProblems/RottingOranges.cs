using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph.BreadthFirstSearchProblems;

public class RottingOranges
{
    private static readonly List<(int X, int Y)> neighbors = [
        (1,0),
        (-1,0),
        (0,1),
        (0,-1),
    ];

    public int OrangesRotting(int[][] grid)
    {
        //iterate over list of oranges
        //if I find a rotting orange I BFS out
        //count each level and mark the orange as rotting (2)
        //I have to finish the array
        //if I find a count of oranges greater than my current count I then replace my current count
        Queue<(int X, int Y)> q = new Queue<(int X, int Y)>();
        for (int i = 0; i < grid.Length; i++) 
        {
            for(int j = 0;  j < grid[i].Length; j++)
            {
                var current = grid[i][j];
                if(current == 2) //orange is rotten
                {
                    q.Enqueue((i,j));
                }
            }
        }

        var minutes = expandOranges(q, grid);

        //check for any remaining oranges
        if(grid.Any(x => x.Any(y => y == 1)))
        {
            return -1;
        }

        return minutes == -1 ? 0 : minutes;
    }

    private int expandOranges(Queue<(int X, int Y)> q, int[][] grid)
    {
        int total = -1;

        while (q.Any())
        {
            int levelNodes = q.Count;
            total++;
            for (int i = 0; i < levelNodes; i++)
            { 
                var vec = q.Dequeue();
                
                foreach(var neighbor in neighbors)
                {
                    (int X, int Y) value = (vec.X + neighbor.X, vec.Y + neighbor.Y);

                    if(value.X < 0 || value.Y < 0)
                    {
                        continue;
                    }

                    if(value.X > grid.Length - 1 || value.Y > grid[value.X].Length - 1)
                    {
                        continue;
                    }

                    var currentValue = grid[value.X][value.Y];

                    if(currentValue == 1)
                    {
                        grid[value.X][value.Y] = 0;
                        q.Enqueue(value);
                    }
                }
            }
        }

        return total;
    }
}
