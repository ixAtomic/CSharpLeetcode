using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph.BreadthFirstSearchProblems;

public class FindIfPathExists
{
    public bool ValidPath(int n, int[][] edges, int source, int destination)
    {
        Dictionary<int, List<int>> adjacencyList = new();

        for (int i = 0; i < n; i++)
        {
            adjacencyList[i] = new List<int>();
        }

        foreach(var edge in edges)
        {
            var from = edge[0];
            var to = edge[1];

            adjacencyList[from].Add(to);
            adjacencyList[to].Add(from);
        }

        Dictionary<int, bool> visited = new Dictionary<int, bool>();
        Queue<int> nodes = new Queue<int>();
        nodes.Enqueue(source);

        while (nodes.Any())
        {
            int current = nodes.Dequeue();
            if(current == destination)
            {
                return true;
            }

            foreach (var neighbor in adjacencyList[current])
            {
                if (!visited.ContainsKey(neighbor))
                {
                    visited[neighbor] = true;
                    nodes.Enqueue(neighbor);
                }
            } 
        }

        return false;
    }
}
