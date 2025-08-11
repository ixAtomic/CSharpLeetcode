using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CapitalOne.Attempt2;

public class LongestConsecutiveSequence2
{
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(nums);
        int longestStreak = 0;

        foreach(int value in set)
        {
            if (set.Contains(value + 1)) continue;

            int currentNum = value - 1;
            int currentStreak = 1;

            while (set.Contains(currentNum))
            {
                currentNum--;
                currentStreak++;
            }

            longestStreak = longestStreak > currentStreak ? longestStreak : currentStreak;
        }

        return longestStreak;
    }
}


