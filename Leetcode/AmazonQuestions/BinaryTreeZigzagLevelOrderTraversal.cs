using LeetCode.GoogleQuestions.Trees_Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AmazonQuestions;

public class BinaryTreeZigzagLevelOrderTraversal
{
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        if(root == null)
        {
            return new List<IList<int>>();
        }

        bool left = true;
        IList<IList<int>> result = new List<IList<int>>();
        Queue<TreeNode> nodes = new Queue<TreeNode>();
        nodes.Enqueue(root);

        while(nodes.Any())
        {
            int count = nodes.Count;
            IList<int> level = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            for (int i = 0; i < count; i++)
            {
                var current = nodes.Dequeue();
                level.Add(current.val);
                stack.Push(current);
            }

            while (stack.Any())
            {
                var current = stack.Pop();

                if (left)
                {
                    if (current.right != null)
                    {
                        nodes.Enqueue(current.right);
                    }

                    if (current.left != null)
                    {
                        nodes.Enqueue(current.left);
                    }
                }
                else
                {
                    if (current.left != null)
                    {
                        nodes.Enqueue(current.left);
                    }

                    if (current.right != null)
                    {
                        nodes.Enqueue(current.right);
                    }
                }
            }
            left = !left;
            result.Add(level);
        }
        return result;
    }
}


public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
 


