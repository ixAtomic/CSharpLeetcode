using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AmazonQuestions;

public class LowestCommonAncestorOfBinaryTree
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        if(root.val == p.val || root.val == q.val)
        {
            return root;
        }

        var current = root;
        while(true)
        {
            var left = false;
            var right = false;
            if (current.left is not null)
            {
                left = find(current.left, p, q);
            }
            
            if(current.right is not null)
            {
                right = find(current.right, p, q);
            }

            if(left && right)
            {
                return current;
            }

            if (left)
            {
                if(current!.left?.val == p.val || current!.left?.val == q.val)
                {
                    return current.left;
                }
                current = current.left;
            }

            if (right)
            {
                if (current!.right?.val == p.val || current!.right?.val == q.val)
                {
                    return current.right;
                }
                current = current.right;
            }
        }
    }

    private bool find(TreeNode root, TreeNode p, TreeNode q)
    {
        if(root.val == p.val)
        {
            return true;
        }

        if(root.val == q.val)
        {
            return true;
        }

        if(root.left is not null)
        {
            if (find(root.left, p, q))
            {
                return true;
            }
        }

        if(root.right is not null)
        {
            if (find(root.right, p, q))
            {
                return true;
            }
        }

        return false;
    }
}
