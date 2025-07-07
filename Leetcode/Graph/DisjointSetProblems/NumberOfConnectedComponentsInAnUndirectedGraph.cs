using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph.DisjointSetProblems;

class NumberOfConnectedComponentsInAnUndirectedGraph
{
    public int CountComponents(int n, int[][] edges)
    {
        var disjointSet = new DisjointSet(n);

        for(int i = 0; i < edges.Length; i++)
        {
            var x = edges[i][0];
            var y = edges[i][1];

            disjointSet.Union(x, y);
        }


        return disjointSet.RootsCount();
    }
}
