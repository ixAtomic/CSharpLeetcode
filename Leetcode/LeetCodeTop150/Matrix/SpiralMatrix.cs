using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.Matrix;

public class SpiralMatrix
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        int upper = 0;
        int right = matrix[0].Length - 1;
        int bottom = matrix.Length - 1;
        int left = 0;
        List<int> result = new List<int>();
        while(result.Count < matrix[0].Length * matrix.Length)
        {
            for(int r = left; r <= right; r++)
            {
                result.Add(matrix[upper][r]);
            }

            for(int b = upper + 1; b <= bottom; b++)
            {
                result.Add(matrix[b][right]);
            }

            if (upper != bottom)
            {
                for (int l = right - 1; l >= left; l--)
                {
                    result.Add(matrix[bottom][l]);
                }
            }

            if (left != right)
            {
                for (int u = bottom - 1; u > upper; u--)
                {
                    result.Add(matrix[u][left]);
                }
            }

            upper++;
            right--;
            left++;
            bottom--;
        }

        return result;
    }
}
