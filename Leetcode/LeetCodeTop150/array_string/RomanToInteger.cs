using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.array_string;

public class RomanToInteger
{
    Dictionary<char, int> _conversions = new Dictionary<char, int>()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };

    public int RomanToInt(string s)
    {
        int total = 0;
        for(int i = 0; i < s.Length; i++)
        {
            var value = _conversions[s[i]];

            if(s.Length > i + 1 && _conversions[s[i + 1]] > value)
            {
                total += _conversions[s[i + 1]] - value;
                i = i + 1;
            }
            else
            {
                total += value;
            }
        }

        return total;
    }
}
