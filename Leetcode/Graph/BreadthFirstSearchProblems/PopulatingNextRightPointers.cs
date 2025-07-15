using LeetCode.Graph.DepthFirstSearchProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph.BreadthFirstSearchProblems;

public class PopulatingNextRightPointers
{
    public Node Connect(Node root)
    {
        // add nodes to queue from right to left
        //every level has 2^i nodes so count down until the nodes are 0 then set next node next to null

        int level = 1;
        Queue<Node> queue = new Queue<Node>();

        if (root is null)
        {
            return null;
        }
        
        if(root.left is null)
        {
            return root;
        }

        queue.Enqueue(root.right);
        queue.Enqueue(root.left);
        NNode next = null;

        while (queue.Any())
        {
            var current = queue.Dequeue();

            if(queue.Count + 1 == Convert.ToInt32(Math.Pow(2, level)))
            {
                current.next = null;
                level++;            
                next = current;
            }
            else
            {
                current.next = next;
                next = current;
            }

            if (current.right is not null)
            {
                queue.Enqueue(current.right);
            }

            if (current.left is not null)
            {
                queue.Enqueue(current.left);
            }
        }

        return root;
    }
}

public class Node
{
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() { }

    public Node(int _val)
    {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next)
    {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
