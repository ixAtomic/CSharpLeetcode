using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150;

public class JumpGameII
{
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
