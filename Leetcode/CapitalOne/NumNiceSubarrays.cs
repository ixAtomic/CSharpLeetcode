using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CapitalOne;

public class NumNiceSubarrays
{
    public int NumberOfSubarrays(int[] nums, int k)
    {
        int left = 0;
        int right = k;
        int results = 0;

        while(right <= nums.Length)
        {
            int count = 0;
            for(int i = left;  i < right; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    count++;
                }
            }

            if(count == k)
            {
                results++;
                left++;
                continue;
            }
            else
            {
                right++;
            }
        }

        return results;
    }
}
