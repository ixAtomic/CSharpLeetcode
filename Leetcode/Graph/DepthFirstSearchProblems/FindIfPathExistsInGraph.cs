using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph.DepthFirstSearchProblems;

class FindIfPathExistsInGraph
{
    public bool ValidPath(int n, int[][] edges, int source, int destination)
    {
        var nodes = new List<List<int>>();
        for(int i = 0;i < n; i++)
        {
            nodes.Add(new List<int>());
        }

        foreach(var edge in edges)
        {
            var vertex1 = edge[0];
            var vertex2 = edge[1];

            nodes[vertex1].Add(vertex2);
            nodes[vertex2].Add(vertex1);
        }

        Stack<int> nodeStack = new Stack<int>();
        Dictionary<int, bool> visited = new Dictionary<int, bool>();

        nodeStack.Push(source);

        while (nodeStack.Count() > 0)
        {
            var node = nodeStack.Pop();

            if(node == destination)
            {
                return true;
            }

            var siblings = nodes.ElementAt(node);
            foreach(var sibling in siblings)
            {
                if (!visited.ContainsKey(sibling))
                {
                    nodeStack.Push(sibling);
                    visited.Add(sibling, true);
                }
            }
        }

        return false;
    }
}
