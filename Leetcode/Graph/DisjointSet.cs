using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph;

//implement quick find
//implement quick union
class DisjointSet
{
    private List<int> _Nodes;

    public DisjointSet(List<int> nodes)
    {
        _Nodes = nodes;
    }

    public void Union(int first, int second)
    {
        var parent = Find(second);

        _Nodes[parent] = first;
    }

    public int Find(int node)
    {
        var current = node;
        while (_Nodes.ElementAtOrDefault(current) != current)
        {
            current = _Nodes.ElementAt(current);
        }

        return current;
    }

    public bool IsConnected(int first, int second)
    {
        var firstParent = Find(first);
        var secondParent = Find(second);

        return firstParent == secondParent;
    }
}
