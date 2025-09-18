using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.array_string;

public class MajorityElementSolution
{
    //Boyer-Moore Vote Algorithm
    //if I have to find a majority element with n/2 occururing element this algorithm could be useful
    public int MajorityElement(int[] nums)
    {
        int num = nums[0];
        int count = 1;
        for(int i = 1; i < nums.Length; i++)
        {
            if (count == 0)
            {
                num = nums[i];
                count = 1;
                continue;
            }

            if (nums[i] == num)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        return num;
    }
}