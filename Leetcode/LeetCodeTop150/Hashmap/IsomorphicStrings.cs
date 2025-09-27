using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.Hashmap;

public class IsomorphicStrings
{
    public bool IsIsomorphic(string s, string t)
    {
        bool sResult = checkWord(s, t);
        bool tResult = checkWord(t, s);

        return sResult && tResult;
    }

    private bool checkWord(string s, string t)
    {
        Dictionary<char, char> letters = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {
            char si = s[i];
            char ti = t[i];

            if (!letters.ContainsKey(si))
            {
                letters.Add(si, ti);
                continue;
            }

            if (letters[si] != ti)
            {
                return false;
            }
        }

        return true;
    }
}
