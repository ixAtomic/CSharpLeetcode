using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.array_string;

public class JumpGameII
{
    public int Jump2(int[] nums)
    {
        int begin = 0;
        int end = 0;
        int turns = 0;
        for(int i = 0; i < nums.Length - 1; i++)
        {
            int jumpLength = i + nums[i];
            
            end = end > jumpLength ? end : jumpLength;

            if(i == begin)
            {
                turns++;
                begin = end;
            }
        }

        return turns;
    }












    public int Jump(int[] nums)
    {
        int end = 0;
        int far = 0;
        int answer = 0;

        for(int i = 0; i < nums.Length - 1; i++) //we do length -1 because we dont need to count from the last index
        {
            int curFar = nums[i] + i;

            far = curFar > far ? curFar : far;

            if(i == end)
            {
                answer++;
                end = far;
            }
        }

        return answer;
    }
}
