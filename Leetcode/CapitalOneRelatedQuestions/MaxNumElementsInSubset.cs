using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CapitalOneRelatedQuestions;

public class MaxNumElementsInSubset
{
    public int MaximumLength(int[] nums)
    {
        Dictionary<int, int> set = new Dictionary<int, int>();

        if(nums.Length == 0)
        {
            return 0;
        }

        int longestStreak = 1;

        foreach (int num in nums)
        {
            if (set.ContainsKey(num))
            {
                set[num]++;
                continue;
            }

            set[num] = 1;
        }

        foreach(var key in set.Keys)
        {
            if (key == 1)
            {
                var value = set[1];
                if(set[1] % 2 == 0)
                {
                    value = value - 1;
                }
                longestStreak = longestStreak > value ? longestStreak : value;
                continue;
            }

            if (set.ContainsKey(key * key) && set[key] > 1) continue;

            int currentStreak = 1;
            double sqrd = Math.Sqrt(key);
            
            if (sqrd % 1 != 0)
            {
                continue;
            }

            int currentValue = (int)sqrd;

            while (set.ContainsKey(currentValue) && set[currentValue] >= 2)
            {
                currentStreak += 2;
                sqrd = Math.Sqrt(currentValue);

                if (sqrd % 1 != 0)
                {
                    break;
                }
                
                currentValue = (int)sqrd;
            }

            longestStreak = longestStreak > currentStreak ? longestStreak : currentStreak;
        }

        return longestStreak;
    }
}
