using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AmazonQuestions;

public class SymmetricTree
{
    public bool IsSymmetric(TreeNode root)
    {
        Queue<TreeNode> nodes = new Queue<TreeNode>();
        nodes.Enqueue(root);

        while (nodes.Any()) 
        { 
            int count = nodes.Count;
            List<TreeNode?> level = new List<TreeNode?>();

            for(int i = 0; i < count; i++)
            {
                var current = nodes.Dequeue();
                level.Add(current?.left ?? null);
                level.Add(current?.right ?? null);

                if(current!.left is not null)
                {
                    nodes.Enqueue(current.left);
                }    
                
                if(current!.right is not null)
                {
                    nodes.Enqueue(current.right);
                }
            }

            int m = 0;
            int n = level.Count - 1;

            while (m < n)
            {
                var left = level.ElementAt(m);
                var right = level.ElementAt(n);

                if(left?.val != right?.val)
                {
                    return false;
                }

                m++;
                n--;
            }
        }

        return true;
    }
}
