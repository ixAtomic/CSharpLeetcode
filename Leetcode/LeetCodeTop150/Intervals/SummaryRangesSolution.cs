using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.Intervals;

public class SummaryRangesSolution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        if (nums.Length == 0)
        {
            return [];
        }
        List<string> result = new List<string>();
        int j = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] + 1 == nums[i])
            {
                continue;
            }

            if (i - 1 - j > 0)
            {
                result.Add($"{nums[j]}->{nums[i - 1]}");
            }
            else
            {
                result.Add(nums[j].ToString());
            }
            j = i;
        }


        if (nums.Length - 1 - j > 0)
        {
            result.Add($"{nums[j]}->{nums[nums.Length - 1]}");
        }
        else
        {
            result.Add(nums[j].ToString());
        }

        return result;
    }
}
