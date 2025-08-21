using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CapitalOne.Q3;

//[0, 1]
//[0, 0]

//x = 0 - 0 = 0
//y = 0 - 1 = -1

//[0, -1]

//0 1
//1 1

//1 1
//1 1
public class ImageOverlap
{
    public int LargestOverlap(int[][] img1, int[][] img2)
    {
        int[]? first = FindStart(img1);
        int[]? second = FindStart(img2);

        if(first is null || second is null)
        {
            return 0;
        }

        int[] translation = [ second[0] - first[0], second[1] - first[1] ];
        Console.WriteLine($"X: {translation[0]}, Y: {translation[1]}");
        int result = 0;
        for(int i = 0; i < img1.Length; i++)
        {
            for(int j = 0; j < img1.Length; j++)
            {
                int x = i + translation[0];
                int y = j + translation[1];

                if(x < 0 || y < 0)
                {
                    continue;
                }

                if(x >= img1.Length || y >= img2.Length)
                {
                    continue;
                }

                if (img1[i][j] == 1 && img2[x][y] == 1)
                {
                    result++;
                }
            }
        }

        return result;
    }

    private int[]? FindStart(int[][] img)
    {
        for(int i = 0; i < img.Length; i++)
        {
            for (int j = 0;j < img[i].Length; j++)
            {
                if(img[j][i] == 1)
                {
                    return [j, i];
                }
            }
        }

        return null;
    }
}
