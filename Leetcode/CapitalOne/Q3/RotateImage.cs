using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CapitalOne.Q3;

public class RotateImage
{
    public void Rotate(int[][] matrix)
    {
        /**
         * [0,0] [1,0] [2,0] [3,0]
         * [0,1] [1,1] [2,1] [3,1]
         * [0,2] [1,2] [2,2] [3,2]
         * [0,3] [1,3] [2,3] [3,3] 
         **/

        /**
         * [0,0] [1,0] [2,0] [3,0] [4,0]
         * [0,1] [1,1] [2,1] [3,1] [4,1]
         * [0,2] [1,2] [2,2] [3,2] [4,2]
         * [0,3] [1,3] [2,3] [3,3] [4,3]
         * [0,4] [1,4] [2,4] [3,4] [4,4]
         **/

        for (int i = 0; i < matrix.Length; i++)
        {
            var indexer = matrix.Length - i - 1;
            int swap = 0;
            for(int j = 0; j < matrix.Length; j++)
            {
                
            }
        }
    }
}
