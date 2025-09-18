using LeetCode.CapitalOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.array_string;

public class JumpGame
{
    public bool CanJump(int[] nums)
    {
        int currentToReach = nums.Length - 1;
        
        for(int i = nums.Length - 2; i >= 0; i--)
        {
            if(i + nums[i] >= currentToReach)
            {
                currentToReach = i;
            }
        }

        return currentToReach == 0;
    }
}
