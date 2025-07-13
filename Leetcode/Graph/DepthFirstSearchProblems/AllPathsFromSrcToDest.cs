using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph.DepthFirstSearchProblems;

class AllPathsFromSrcToDest
{
    private Dictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();
    private Dictionary<int, bool> memo = new Dictionary<int, bool>();
    private HashSet<int> visited = new();
    private int _destination;

    public bool LeadsToDestination(int n, int[][] edges, int source, int destination)
    {
        for(int i = 0; i < n; i++)
        {
            adjacencyList[i] = new List<int>();
        }

        foreach(var edge in edges)
        {
            var from = edge[0];
            var to = edge[1];

            adjacencyList[from].Add(to);
        }

        if (adjacencyList[destination].Any()) //if destination has any edges then it is a cycle not an end point
        {
            return false;
        }

        _destination = destination;
        return Backtrack(source);
    }

    private bool Backtrack(int currentNode)
    {
        if (memo.ContainsKey(currentNode))
            return memo[currentNode];

        if (currentNode == _destination)
        {
            return true;
        }

        if (!adjacencyList[currentNode].Any())
        {
            return false;
        }

        foreach (var neighbor in adjacencyList[currentNode])
        {
            if (!visited.Contains(neighbor))
            {
                visited.Add(neighbor);
                if (!Backtrack(neighbor))
                {
                    memo[currentNode] = false;
                    return false;
                }
                visited.Remove(neighbor);
            }
            else
            {
                memo[currentNode] = false;
                return false;
            }
        }

        memo[currentNode] = true;
        return true;
    }
}
