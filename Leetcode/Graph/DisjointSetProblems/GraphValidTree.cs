using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph.DisjointSetProblems;

class GraphValidTree
{
    public bool ValidTree(int n, int[][] edges)
    {
        if (n == 1) return true;

        if (edges.Length != n - 1) return false; //couldnt get this part

        var DisjointSet = new DisjointSet(n);

        for(int i = 0; i < edges.Length; i++)
        {
            var x = edges[i][0];
            var y = edges[i][1];

            if (DisjointSet.IsConnected(x, y)) return false;

            DisjointSet.Union(x, y);
        }

        var roots = new HashSet<int>();
        for (int i = 0; i < n-1; i++)
        {
            roots.Add(DisjointSet.Find(i));
        }

        return roots.Count == 1;
    }
}



