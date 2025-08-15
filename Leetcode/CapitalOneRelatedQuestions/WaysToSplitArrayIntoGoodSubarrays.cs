using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CapitalOneRelatedQuestions;

public class WaysToSplitArrayIntoGoodSubarrays
{
    public int NumberOfGoodSubarraySplits(int[] nums)
    {
        const int MOD = 1000000007;
        long subarrays = 0;
        int sum = 0;

        Dictionary<int, int> set = new Dictionary<int, int>();
        set[0] = 1;
        foreach(int num in nums)
        {
            sum += num;

            if (!set.ContainsKey(sum))
            {
                subarrays++;
            }

            if (set.ContainsKey(sum))
            {
                set[sum]++;
                continue;
            }

            set[sum] = 1;
        }

        return (int)(subarrays % MOD);
    }
}
