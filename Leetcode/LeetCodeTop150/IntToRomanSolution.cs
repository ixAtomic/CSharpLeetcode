using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150;

public class IntToRomanSolution
{
    Dictionary<int, char> _conversions = new Dictionary<int, char>()
    {
        { 1, 'I' },
        { 5, 'V' },
        { 10, 'X' },
        { 50, 'L' },
        { 100, 'C' },
        { 500, 'D' },
        { 1000, 'M' }
    };

    private int[] _values = [1000, 100, 10, 1];

    public string IntToRoman(int num)
    {
        int remainder = num;
        int i = 0;
        string result = string.Empty;
        while(remainder > 0)
        {
            int value = remainder / _values[i];
            int remaining = remainder % _values[i];

            if((value == 4 || value == 9) && i != 0)
            {
                int comparer = _values[i] * value + _values[i];
                char second = _conversions[comparer];
                char first = _conversions[_values[i]];

                result += first;
                result += second;
                remainder = remaining;
                continue;
            }

            if(value == 0)
            {
                i++;
                continue;
            }

            if(value >= 5)
            {
                int comparer = _values[i] * 5;
                char first = _conversions[comparer];
                result += first;
                value = value - 5;
            }

            for(int j = 0; j < value; j++)
            {
                result += _conversions[_values[i]];
            }

            remainder = remaining;
        }

        return result;
    }

}
