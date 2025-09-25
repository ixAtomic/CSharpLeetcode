using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.TwoPointers;

public class ValidPalindrome
{
    public bool IsPalindrome(string s)
    {
        string res = s.Replace(' ', '\0');
        string? thestring = String.Join("", res.Where(x => char.IsAsciiLetterOrDigit(x))).ToLower();

        if (string.IsNullOrEmpty(thestring)) return true;

        int i = 0;
        int j = thestring.Length - 1;
        while (i < j)
        {
            Console.Write($"i: {i}, value: {thestring[i]} j: {j}, value: {thestring[j]}");
            if(thestring[i] != thestring[j])
            {
                return false;
            }
            i++;
            j--;
        }

        return true;
    }
}
