using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.Hashmap;

public class RansomNote
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> letters = new Dictionary<char, int>();
        foreach(char c in magazine)
        {
            if (!letters.ContainsKey(c))
            {
                letters.Add(c, 0);
            }
            letters[c]++;
        }

        foreach(char c in ransomNote)
        {
            if (!letters.ContainsKey(c))
            {
                return false;
            }

            letters[c]--;

            if (letters[c] < 0)
            {
                return false;
            }
        }

        return true;
    }
}
