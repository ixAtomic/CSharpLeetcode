using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTestProject.LeetCodeTop150.array_string_tests;

public class CandySolution
{
    public int Candy(int[] ratings)
    {
        for(int i = 0; i < ratings.Length; i++)
        {
            int left = i - 1 > 0 ? ratings[i - 1] : 0;
            int right = i + 1 < ratings.Length - 1 ? ratings[i + 1] : 0;
            int current = ratings[i];

            //1,1,20,5,1
            //5,4,3,2,1
            
        }
        throw new NotImplementedException();
    }
}
