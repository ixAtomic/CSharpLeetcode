using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CapitalOne;

public class LongestConsecutiveSequence2
{
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> values = new HashSet<int>(nums);
        int longestStreak = 0;
        foreach(int num in values)
        {
            if (!values.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;
                while (values.Contains(num + 1))
                {
                    currentNum++;
                    currentStreak++;
                }
                longestStreak = longestStreak > currentStreak ? longestStreak : currentStreak;
            }
        }

        return longestStreak;
    }
}


