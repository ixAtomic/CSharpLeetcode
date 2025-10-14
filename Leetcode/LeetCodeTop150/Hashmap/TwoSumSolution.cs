using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.Hashmap;

public class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> history = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (history.ContainsKey(complement))
            {
                return [i, history[complement]];
            }

            history[nums[i]] = i;
        }

        return [];
    }
}
