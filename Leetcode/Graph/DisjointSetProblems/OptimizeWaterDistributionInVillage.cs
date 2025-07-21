using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LeetCode.Graph.DisjointSetProblems;

public class OptimizeWaterDistributionInVillage
{
    public int MinCostToSupplyWater(int n, int[] wells, int[][] pipes)
    {
        var disjointSet = new DisjointSet(n + 1);
        PriorityQueue<Edge, int> queue = new PriorityQueue<Edge, int>();
        var connections = n;
        for (int i = 0; i < pipes.Length; i++)
        {
            var x = pipes[i][0] - 1;
            var y = pipes[i][1] - 1;
            var cost = pipes[i][2];

            queue.Enqueue(new Edge(x, y, cost), cost);
        }

        for(int i = 0; i < wells.Length; i++)
        {
            queue.Enqueue(new Edge(n, i, wells[i]), wells[i]);
        }

        int total = 0;
        while (queue.Count > 0 && connections > 0)
        {
            var current = queue.Dequeue();

            if (disjointSet.IsConnected(current.from, current.to))
            {
                continue;
            }

            disjointSet.Union(current.from, current.to);

            Console.WriteLine($"from: {current.from}, to: {current.to}, cost: {current.cost}");
            total += current.cost;

            connections--;
        }
        
        return total;
    }

    private record Edge(int from, int to, int cost);
}

