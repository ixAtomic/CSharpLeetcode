using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.SlidingWindow;

public class MinSizeSubarraySum
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int minLength = int.MaxValue;
        int sum = 0;
        int left = 0;
        for (int right = 0; right < nums.Length; right++)
        {
            sum += nums[right];
            while (sum >= target)
            {
                minLength = Math.Min(minLength, right - left + 1);
                sum -= nums[left++];
            }
        }

        return minLength == int.MaxValue ? 0 : minLength;
    }
}
