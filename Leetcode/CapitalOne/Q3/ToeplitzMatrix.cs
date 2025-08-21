using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CapitalOne.Q3;

public class ToeplitzMatrix
{
    public bool IsToeplitzMatrix(int[][] matrix)
    {
        int[] diagonal = [1, 1]; 
        for(int i = 0; i < matrix.Length; i++)
        {
            for(int j = 0; j < matrix[i].Length; j++)
            {
                var current = matrix[i][j];
                if(current == -1)
                {
                    continue;
                }

                matrix[i][j] = -1;
                int X = diagonal[0] + i;
                int Y = diagonal[1] + j;
                while (X < matrix.Length && Y < matrix[i].Length)
                {
                    if (matrix[X][Y] == current)
                    {
                        matrix[X][Y] = -1;
                    }
                    else
                    {
                        return false;
                    }
                    X = diagonal[0] + X;
                    Y = diagonal[1] + Y;
                }
            }
        }

        return true;
    }
}
