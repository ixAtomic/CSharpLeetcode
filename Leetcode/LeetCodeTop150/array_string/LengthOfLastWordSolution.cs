using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.array_string;

public class LengthOfLastWordSolution
{
    public int LengthOfLastWord(string s)
    {
        string res = s.Trim();
        string[] list = res.Split(' ');
        return list[list.Length - 1].Length;
    }
}
