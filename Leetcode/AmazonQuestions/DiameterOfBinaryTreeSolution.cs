using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AmazonQuestions;

//the problem with my solution is that I am calculating the depth as I traverse down I am not getting the diameter
public class DiameterOfBinaryTreeSolution
{
    public int DiameterOfBinaryTree(TreeNode root)
    {
        return FindBottom(root, 0);
    }

    private int FindBottom(TreeNode current, int count)
    {
        if(current is null)
        {
            return count;
        }

        count++;

        int left = FindBottom(current.left, count);
        int right = FindBottom(current.right, count);

        return left > right ? left : right;
    }
}

//proper implementation:

public class DiameterOfBinaryTreeSolution2
{
    public int DiameterOfBinaryTree2(TreeNode root)
    {
        int diameter = 0;
        Depth(root, ref diameter);
        return diameter;
    }

    private int Depth(TreeNode node, ref int diameter)
    {
        if (node == null)
            return 0;

        int left = Depth(node.left, ref diameter);
        int right = Depth(node.right, ref diameter);

        diameter = Math.Max(diameter, left + right);

        return 1 + Math.Max(left, right);
    }
}



