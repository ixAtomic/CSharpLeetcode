using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AmazonQuestions;

public class ValidateBinarySearchTree
{
    public bool IsValidBST(TreeNode root)
    {
        Queue<TreeNode> nodes = new Queue<TreeNode>();
        nodes.Enqueue(root);
        //[32,26,47,19,null,null,56,null,27]
        while (nodes.Any())
        {
            var current = nodes.Dequeue();

            if (current.val != root.val)
            {
                bool isLeft = current.val < root.val;

                if (isLeft)
                {
                    if (current.left is not null && current.left.val > root.val) return false;

                    if (current.right is not null && current.right.val > root.val) return false;
                }
                else
                {
                    if (current.left is not null && current.left.val < root.val) return false;

                    if (current.right is not null && current.right.val < root.val) return false;
                }
            }

            if (current.left is not null && current.val <= current.left.val)
            {
                return false;
            }

            if(current.right is not null && current.val >= current.right.val)
            {
                return false;
            }

            if(current.left is not null)
            {
                nodes.Enqueue(current.left);
            }
            
            if(current.right is not null)
            {
                nodes.Enqueue(current.right);
            }
        }

        return true;
    }
}
