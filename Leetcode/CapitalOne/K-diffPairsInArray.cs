using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CapitalOne;

public class K_diffPairsInArray
{
    public int FindPairs(int[] nums, int k)
    {
        Dictionary<int, int> set = new Dictionary<int, int>();

        foreach(var num in nums)
        {
            if (!set.ContainsKey(num))
            {
                set.Add(num, 1);
                continue;
            }

            set[num]++;
        }

        int count = 0;
        foreach(var value in set.Keys)
        {
            if (k == 0 && set[value] > 1)
            {
                count++;
            }
            else if (set.ContainsKey(value + k) && k != 0)
            {
                count++;
            }
        }

        return count;
    }
}
