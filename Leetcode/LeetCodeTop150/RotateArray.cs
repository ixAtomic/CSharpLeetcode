using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150;

public class RotateArray
{
    public void Rotate(int[] nums, int k)
    {
        for(int i = 0; i < k; i++)
        {
            int current = k - i;
            int currentIndex = nums.Length - 1 - current;

            int temp = nums[currentIndex];
            nums[currentIndex] = nums[i];
            nums[i] = temp;
        }
    }
}
