using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.TwoPointers;

public class _3Sum
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        IList<IList<int>> result = [];
        int? previous = null;
        for(int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            int low = i + 1;
            int high = nums.Length - 1;
            while (low < high)
            {
                int value = nums[i] + nums[low] + nums[high];
                if (value == 0)
                {
                    result.Add([nums[i], nums[low], nums[high]]);

                    high--;
                    low++;

                    while (low < high && nums[low] == nums[low - 1]) low++;

                    while (low < high && nums[high] == nums[high + 1]) high--; 
                }
                else if (value > 0)
                {
                    high--;
                }
                else
                {
                    low++;
                }
            }
        }

        return result;
    }
}
