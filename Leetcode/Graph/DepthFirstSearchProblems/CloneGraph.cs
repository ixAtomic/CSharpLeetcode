using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode.Graph.DepthFirstSearchProblems;
class CloneGraphSolution
{
    private Dictionary<Node, Node> _visited = new Dictionary<Node, Node>();

    public Node CloneGraph(Node node)
    {
        if (node == null)
            return null;

        if (_visited.ContainsKey(node)) //struggled to remember to put the base case in the right spot here
            return _visited[node];

        var copy = new Node(node.val);
        _visited.Add(node, copy);

        foreach (var neighbor in node.neighbors)
        {
            copy.neighbors.Add(CloneGraph(neighbor));
        }

        return copy;
    }
}

public class Node
{
    public int val;
    public IList<Node> neighbors;

    public Node()
    {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val)
    {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors)
    {
        val = _val;
        neighbors = _neighbors;
    }
}
