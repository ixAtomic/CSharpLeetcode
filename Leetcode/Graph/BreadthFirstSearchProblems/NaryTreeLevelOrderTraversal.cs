using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph.BreadthFirstSearchProblems;

public class NNode
{
    public int val;
    public IList<NNode> children;

    public NNode() { }

    public NNode(int _val)
    {
        val = _val;
    }

    public NNode(int _val, IList<NNode> _children)
    {
        val = _val;
        children = _children;
    }
}

public class NaryTreeLevelOrderTraversal
{
    public IList<IList<int>> LevelOrder(NNode root)
    {
        int level = 0;
        IList<IList<int>> levelOrder = new List<IList<int>>();
        int remainingNodes = 1;
        Queue<NNode> nodes = new Queue<NNode>();
        nodes.Enqueue(root);
        levelOrder.Add(new List<int>());

        while (nodes.Any())
        {
            var current = nodes.Dequeue();
            levelOrder[level].Add(current.val);
            remainingNodes--;

            if(remainingNodes == 0)
            {
                level++;
                levelOrder.Add(new List<int>());
            }

            foreach(var node in current.children)
            {

            }
        }
    }
}


