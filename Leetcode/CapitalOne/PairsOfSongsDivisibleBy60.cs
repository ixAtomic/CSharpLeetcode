using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CapitalOne;

public class PairsOfSongsDivisibleBy60
{
    public int NumPairsDivisibleBy60(int[] time)
    {
        int count = 0;
        int n = time.Length;
        Dictionary<int, int> set = new Dictionary<int, int>();
        foreach(var t in time)
        {
            var value = t % 60;
            var inverse = 60 - value;
            if(value == 0)
            {
                inverse = 0;
            }

            if (set.ContainsKey(inverse))
            {
                count += set[inverse];
            }

            if (set.ContainsKey(value))
            {
                set[value]++;
                continue;
            }

            set[value] = 1;
        }

        return count;
    }
}
