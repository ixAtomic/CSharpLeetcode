using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CapitalOne.Q3;

public class TransposeMatrix
{
    public int[][] Transpose(int[][] matrix)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;
        int[][] ans = new int[n][];
        for (int i = 0; i < n; i++)
        {
            ans[i] = new int[m];
            for (int j = 0; j < m; j++)
            {
                ans[i][j] = matrix[j][i];
            }
        }
        return ans;
    }
}
