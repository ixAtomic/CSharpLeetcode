using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.Hashmap;

public class LongestConsecutiveSequence
{
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> history = new HashSet<int>(nums);
        int max = 1;
        foreach(int num in history)
        {
            if (history.Contains(num + 1)) continue;

            int target = num - 1;
            int localMax = 0;
            while (history.Contains(target))
            {
                localMax++;
                target--;
            }

            max = Math.Max(max, localMax);
        }

        return max;
    }
}
