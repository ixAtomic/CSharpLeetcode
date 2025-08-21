using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CapitalOne.Q3;

public class ReshapeTheMatrix
{
    public int[][] MatrixReshape(int[][] mat, int r, int c)
    {
        var matrixTot = mat.Length * mat[0].Length;
        var formTot = r * c;

        if (formTot != matrixTot)
        {
            return mat;
        }

        int[][] newMatrix = new int[r][];
        for (int i = 0; i < r; i++)
        {
            newMatrix[i] = new int[c];
        }

        int x = 0;
        int y = 0;
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                if (y >= mat[0].Length)
                {
                    y = 0;
                    x++;
                }

                newMatrix[i][j] = mat[x][y];

                y++;
            }
        }

        return newMatrix;
    }
}
