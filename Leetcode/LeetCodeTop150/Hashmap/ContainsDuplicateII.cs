using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.Hashmap;

public class ContainsDuplicateII
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        //3
        //[1, 2, 3, 1, 1]

        Dictionary<int, int> history = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if (!history.ContainsKey(nums[i]))
            {
                history.Add(nums[i], i);
                continue;
            }

            int prevIndex = history[nums[i]];

            if(i - prevIndex <= k)
            {
                return true;
            }
            history[nums[i]] = i;
        }
        return false;
    }
}
