using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CapitalOne;

public class DiagonalTraverseII
{
    public int[] FindDiagonalOrder(IList<IList<int>> nums)
    {
        List<(int, int)> directions =
        [
            new(1,0),
            new(0,1)
        ];
        Queue<(int, int)> nodes = new Queue<(int, int)>();
        HashSet<(int,int)> visited = new HashSet<(int, int)> ();
        nodes.Enqueue((0, 0));
        List<int> results = new List<int>();
        while (nodes.Any())
        {
            var current = nodes.Dequeue();

            results.Add(nums[current.Item1][current.Item2]);

            foreach(var direction in directions)
            {
                (int, int) neighbor = new(current.Item1 + direction.Item1, current.Item2 + direction.Item2);

                if (neighbor.Item1 < 0) continue;

                if (neighbor.Item2 < 0) continue;

                if (neighbor.Item1 > nums.Count - 1) continue;

                if (neighbor.Item2 > nums[neighbor.Item1].Count - 1) continue;

                if (!visited.Contains(neighbor))
                {
                    visited.Add(neighbor);
                    nodes.Enqueue(neighbor);
                }
            }
        }

        return results.ToArray();
    }
}
