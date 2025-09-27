using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.Matrix;

public class RotateImage
{
    public void Rotate(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = i + 1; j < matrix[i].Length; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }

        //second reverse matrix
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix.Length / 2; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[i][matrix.Length - 1 - j];
                matrix[i][matrix.Length - 1 - j] = temp;
            }
        }
    }

}
