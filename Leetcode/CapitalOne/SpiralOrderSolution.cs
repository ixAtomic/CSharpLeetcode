using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CapitalOne;

public class SpiralOrderSolution
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        int xBoundMin = 0;
        int xBoundMax = matrix[0].Length;
        int yBoundMin = 1;
        int yBoundMax = matrix.Length;
        int total = xBoundMax * yBoundMax;

        int direction = 0; //0 = left, 1 = down, 2 = right, 3 = up

        IList<int> result = new List<int>();

        int column = 0;
        int row = 0;
        while(total > 0)
        {
            total--;
            switch (direction)
            {
                case 0:
                    result.Add(matrix[row][column]);

                    if (column + 1 >= xBoundMax)
                    {
                        direction = 1;
                        row++;
                        break;
                    }
                    column++;
                    break;

                case 1:
                    result.Add(matrix[row][column]);
                    if (row + 1 >= yBoundMax)
                    {
                        direction = 2;
                        column--;
                        break;
                    }
                    row++;
                    break;

                case 2:
                    result.Add(matrix[row][column]);

                    if (column <= xBoundMin)
                    {
                        direction = 3;
                        row--;
                        break;
                    }

                    column--;
                    break;

                case 3:
                    result.Add(matrix[row][column]);

                    if (row <= yBoundMin)
                    {
                        direction = 0;
                        xBoundMin++;
                        xBoundMax--;
                        yBoundMin++;
                        yBoundMax--;
                        column++;
                        break;
                    }

                    row--;
                    break;
            }
        }
        return result;
    }
}
