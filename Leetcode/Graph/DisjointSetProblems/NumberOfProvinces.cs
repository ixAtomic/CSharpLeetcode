using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph.DisjointSetProblems;

public class NumberOfProvinces
{
    private List<int> parent = new List<int>();
    private List<int> rank = new List<int>();

    public int FindCircleNum(int[][] isConnected)
    {
        for (int i = 0; i < isConnected.Length; i++)
        {
            parent.Add(i);
            rank.Add(0);
        }

        foreach(var node in isConnected.Select((value, index) => new { value, index }))
        {
            foreach(var city in node.value.Select((value, index) => new { value, index }))
            {
                if (city.value != 1) continue;

                Union(node.index, city.index);
            }
        }

        var roots = new HashSet<int>();
        for (int i = 0; i < parent.Count; i++)
        {
            roots.Add(Find(i));
        }
        return roots.Count;
    }

    public int Find(int x)
    {
        if (parent[x] == x)
            return parent[x];
        return parent[x] = Find(parent[x]); // Path compression
    }

    public void Union(int x, int y)
    {
        int rootX = Find(x);
        int rootY = Find(y);
        if (rootX == rootY) return;

        if (rank[rootX] < rank[rootY])
            parent[rootX] = rootY;
        else if (rank[rootX] > rank[rootY])
            parent[rootY] = rootX;
        else
        {
            parent[rootY] = rootX;
            rank[rootX]++;
        }
    }
}
