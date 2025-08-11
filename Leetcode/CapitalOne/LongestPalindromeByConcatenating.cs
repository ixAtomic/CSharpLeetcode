using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CapitalOne;

public class LongestPalindromeByConcatenating
{
    public int LongestPalindrome(string[] words)
    {
        var counts = new Dictionary<string, int>();
        foreach (var word in words)
            counts[word] = counts.GetValueOrDefault(word, 0) + 1;

        int length = 0;
        bool hasMiddle = false;

        foreach (var word in counts.Keys.ToList())
        {
            var reverse = new string(word.Reverse().ToArray());
            if (word == reverse)
            {
                int pairs = counts[word] / 2;
                length += pairs * 4;
                if (counts[word] % 2 == 1)
                    hasMiddle = true;
            }
            else if (counts.ContainsKey(reverse))
            {
                int pairs = Math.Min(counts[word], counts[reverse]);
                length += pairs * 4;
                counts[word] -= pairs;
                counts[reverse] -= pairs;
            }
        }

        if (hasMiddle)
            length += 2;

        return length;
    }
}
