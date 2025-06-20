using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.GoogleQuestions.Trees_Graphs;

public class CountCompleteTreeNodes
{
    public int CountNodes(TreeNode root)
    {
        if(root is null)
        {
            return 0;
        } 

        Queue<TreeNode> nodes = new Queue<TreeNode>();
        nodes.Enqueue(root);
        int count = 0;

        while (nodes.Count > 0)
        {
            count++;
            var current = nodes.Dequeue();

            if(current.left is not null)
            {
                nodes.Enqueue(current.left);
            }

            if(current.right is not null)
            {
                nodes.Enqueue(current.right);
            }
        }

        return count;
    }
}


public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}


