using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.array_string;

public class RemoveElementSolution
{
    public int RemoveElement(int[] nums, int val)
    {
        int count = 0;
        int i = 0;
        int j = nums.Length - 1;
        while(i <= j)
        {
            if (nums[i] == val)
            {
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;

                count++;
                j--;
            }
            else
            {
                i++;
            }
        }

        return nums.Length - count;
    }
}
