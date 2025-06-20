using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.GoogleQuestions;

class BackspaceStringCompare
{
    public bool BackspaceCompare(string s, string t)
    {
        Stack<char> sCount = new();
        Stack<char> tCount = new();

        foreach(var c in s)
        {
            if(c == '#')
            {
                sCount.TryPop(out char result);
                continue;
            }

            sCount.Push(c);
        }

        foreach(var c in t)
        {
            if (c == '#')
            {
                tCount.TryPop(out char result);
                continue;
            }

            tCount.Push(c);
        }

        if(sCount.Count() != tCount.Count)
        {
            return false;
        }

        while(sCount.Count > 0)
        {
            var sVal = sCount.Pop();
            var tVal = tCount.Pop();

            if(sVal != tVal)
            {
                return false;
            }
        }

        return true;
    }
}
