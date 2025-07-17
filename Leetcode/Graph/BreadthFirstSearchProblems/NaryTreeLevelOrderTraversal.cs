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
        if(root is null)
        {
            return [];
        }

        int level = 0;
        IList<IList<int>> levelOrder = new List<IList<int>>();
        Queue<NNode?> nodes = new Queue<NNode?>();
        nodes.Enqueue(root);
        nodes.Enqueue(null);
        levelOrder.Add(new List<int>());

        while (nodes.Any())
        {
            var current = nodes.Dequeue();

            if(current is null)
            {
                if(nodes.Count == 0)
                {
                    continue;
                }

                level++;
                levelOrder.Add(new List<int>());
                nodes.Enqueue(null);
                continue;
            }

            levelOrder[level].Add(current.val);

            if (current.children is null) 
            {
                continue;
            }

            foreach(var node in current.children)
            {
                nodes.Enqueue((NNode)node);
            }
        }

        return levelOrder;
    }

    //slightly better solution maybe
    public IList<IList<int>> LevelOrder2(NNode root)
    {
        var levelOrder = new List<IList<int>>();

        if (root == null)
            return levelOrder;

        var q = new Queue<NNode>();
        q.Enqueue(root);

        var levelSize = q.Count;
        while (q.Count > 0)
        {
            levelSize = q.Count;
            var levelVals = new List<int>();
            while (levelSize > 0)
            {
                var curr = q.Dequeue();
                levelVals.Add(curr.val);

                foreach (var child in curr.children)
                    q.Enqueue(child);

                --levelSize;
            }

            levelOrder.Add(levelVals);
        }

        return levelOrder;
    }
}


