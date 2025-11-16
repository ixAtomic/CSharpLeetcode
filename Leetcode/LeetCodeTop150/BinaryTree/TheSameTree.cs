using LeetCode.AmazonQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.BinaryTree;

public class TheSameTree
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if(p is null && q is null)
        {
            return true;
        }

        if(p?.val != q?.val) return false;
        bool left = IsSameTree(p.left, q.left);
        bool right = IsSameTree(p.right, q.right);

        if(left && right)
        {
            return true;
        }

        return false;
    }
}
