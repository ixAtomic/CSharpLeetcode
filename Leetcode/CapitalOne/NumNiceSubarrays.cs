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
        int currSum = 0;
        int subArrays = 0;
        Dictionary<int, int> set = new Dictionary<int, int>();
        set[0] = 1;
        for(int left = 0; left < nums.Length; left++)
        {
            currSum += nums[left] % 2;
            var valueToFind = currSum - k;

            if (set.ContainsKey(valueToFind))
            {
                subArrays += set[valueToFind];
            }

            if (set.ContainsKey(currSum))
            {
                set[currSum]++;
                continue;
            }

            set[currSum] = 1;
        }

        return subArrays;
    }
}
