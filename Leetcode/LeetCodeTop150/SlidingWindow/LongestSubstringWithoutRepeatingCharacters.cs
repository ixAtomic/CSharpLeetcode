using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.SlidingWindow;

public class LongestSubstringWithoutRepeatingCharacters
{
    //pwwkew
    // length = 3
    //maxlength = 3
    //set = p: 0, w: 1, k: 1, e: 1,
    public int LengthOfLongestSubstring(string s)
    {
        Dictionary<char, int> set = new Dictionary<char, int>();
        int maxLength = 0;
        int left = 0;
        for(int right = 0; right < s.Length;  right++)
        {
            char c = s[right];
            while (set.ContainsKey(c) && set[c] > 0)
            {
                set[s[left++]]--;
            }

            maxLength = Math.Max(maxLength, right - left + 1);
            if (set.ContainsKey(c))
            {
                set[c]++;
            }
            else
            {
                set.Add(c, 1);
            }
        }

        return maxLength;
    }
}
