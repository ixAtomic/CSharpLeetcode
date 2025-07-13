using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph.BreadthFirstSearchProblems;

public class AllPathsFromSrcToTrgt
{
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
    {
        var endNode = graph.Length - 1;
        Dictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();

        for(int i = 0; i < graph.Length; i++)
        {
            adjacencyList[i] = new();
        }

        foreach(var node in graph.Select((value, from) => new { value, from }))
        {
            foreach(var to in node.value)
            {
                adjacencyList[node.from].Add(to);
            }
        }

        Dictionary<int, bool> visited = new Dictionary<int, bool>();
        Queue<(int node, List<int> path)> queue = new Queue<(int, List<int>)>();
        IList<IList<int>> paths = [];
        queue.Enqueue((0, [0]));

        while (queue.Any())
        {
            var current = queue.Dequeue();
            
            if(current.node == endNode)
            {
                paths.Add(current.path);
                continue;
            }

            foreach(var neighbor in adjacencyList[current.node])
            {
                var updatedList = new List<int>();
                updatedList.AddRange(current.path);
                updatedList.Add(neighbor);
                queue.Enqueue((neighbor, updatedList));
            }
        }

        return paths;
    }
}
