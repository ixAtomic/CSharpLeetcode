using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.array_string;

public class ZigzagConversion
{
    public string Convert(string s, int numRows)
    {
        int sections = (int)Math.Ceiling((double)s.Length / (2 * numRows - 2) * (numRows - 1));
        char[][] grid = new char[numRows][];

        for (int i = 0; i < numRows; i++)
        {
            grid[i] = new char[sections];
        }

        int vi = 0;
        int currentRow = 0;
        int currentColumn = 0;
        while(vi < s.Length)
        {
            while(currentRow < numRows && vi < s.Length)
            {
                grid[currentRow][currentColumn] = s[vi];
                currentRow++;
                vi++;
            }

            currentColumn++;
            currentRow-=2;
            while (currentRow > 0 && currentColumn < (numRows - 1) * sections && vi < s.Length)
            {
                grid[currentRow][currentColumn] = s[vi];
                currentColumn++;
                currentRow--;
                vi++;
            }
        }

        string result = string.Empty;
        for (int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] != '\0')
                {
                    result += grid[i][j];
                }
            }
        }
        return result;
    }
}
