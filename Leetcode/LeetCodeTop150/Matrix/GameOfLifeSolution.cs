using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.Matrix;

public class GameOfLifeSolution
{
    private int[][] vecs = [
        [1,0],
        [1,1],
        [1,-1],
        [0,1],
        [-1,-1],
        [-1,0],
        [-1,1],
        [0,-1]
    ];

    public void GameOfLife(int[][] board)
    {
        for(int i = 0; i < board.Length; i++)
        {
            for(int j = 0; j < board[i].Length; j++)
            {
                int current = board[i][j];
                int alive = 0;
                for(int v = 0; v < vecs.Length; v++)
                {
                    int x = i + vecs[v][0];
                    int y = j + vecs[v][1];

                    if(x < 0 || x > board.Length - 1)
                    {
                        continue;
                    }

                    if(y < 0 || y > board[0].Length - 1)
                    {
                        continue;
                    }

                    if (board[x][y] == 1 || board[x][y] == -1)
                    {
                        alive++;
                    }
                }

                if(current == 1 && (alive < 2 || alive > 3))
                {
                    board[i][j] = -1;
                }

                if(current == 0 && alive == 3)
                {
                    board[i][j] = 2;
                }
            }
        }

        for(int i = 0; i < board.Length; i++)
        {
            for(int j = 0; j < board[i].Length; j++)
            {
                if(board[i][j] == -1)
                {
                    board[i][j] = 0;
                }

                if(board[i][j] == 2)
                {
                    board[i][j] = 1;
                }
            }
        }
    }
}
