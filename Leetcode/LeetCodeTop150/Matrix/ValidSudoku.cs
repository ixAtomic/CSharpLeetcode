using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.Matrix;

public class ValidSudoku
{
    //0 - (3 - 1) = 1
    //
    //if result > 0 then set the remainder to the y index otherwise y index is 0
    int[] rowSeen = new int[9];
    int[] colSeen = new int[9];
    int[] sectionSeen = new int[9];
    int sectionLength = 3;
    public bool IsValidSudoku(char[][] board)
    {
        int[] rowSeen = new int[9];
        int[] colSeen = new int[9];
        int[] sectionSeen = new int[9];
        int sectionLength = 3;

        for (int i = 0; i < board.Length; i++)
        {
            //section length = 3
            //i = 4
            //syid = 3
            //sxid = 3
            int syid = sectionLength * (i / sectionLength);
            int sxid = sectionLength * (i - syid);
            for(int j = 0; j < board[i].Length; j++)
            {
                char row = board[i][j];
                char col = board[j][i];
                int yid = (j / sectionLength) + syid;
                int xid = (j - sectionLength * (j / sectionLength)) + sxid;
                char section = board[yid][xid];

                if (rowSeen.Contains(row) && row != '.') return false;

                if(colSeen.Contains(col) && col != '.') return false;

                if(sectionSeen.Contains(section) && section != '.') return false;

                rowSeen[j] = row; 
                colSeen[j] = col; 
                sectionSeen[j] = section;
            }
            Array.Clear(rowSeen, 0, 9);
            Array.Clear (colSeen, 0, 9);
            Array.Clear(sectionSeen, 0, 9);
        }

        return true;
    }
}
