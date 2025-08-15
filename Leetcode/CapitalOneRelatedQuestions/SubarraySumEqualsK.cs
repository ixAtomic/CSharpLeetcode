using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CapitalOneRelatedQuestions;

public class SubarraySumEqualsK
{
    public int SubarraySum(int[] nums, int k)
    {
        Dictionary<int, int> set = new Dictionary<int, int>();
        set[0] = 1;
        int count = 0;
        int total = 0;
        foreach(var num in nums)
        {
            total += num;

            var valueToFind = total - k;

            if (set.ContainsKey(valueToFind))
            {
                count += set[valueToFind];
            }

            if (set.ContainsKey(total))
            {
                set[total]++;
            }

            set[total] = 1;
        }

        return count;
    }
}
