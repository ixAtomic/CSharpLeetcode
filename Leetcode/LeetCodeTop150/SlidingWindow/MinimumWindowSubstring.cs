using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.SlidingWindow;

public class MinimumWindowSubstring
{
    public string MinWindow(string s, string t)
    {
        Dictionary<char, int> characters = new Dictionary<char, int>();
        int required = t.Length;
        for(int i = 0; i < required; i++)
        {
            if(!characters.ContainsKey(t[i]))
            {
                characters.Add(t[i], 0);
            }

            characters[t[i]]++;
        }

        int j = 0;
        string result = string.Empty;
        for(int i = 0; i < s.Length; i++)
        {
            char current = s[i];

            if (!characters.ContainsKey(current))
            {
                continue;
            }


            characters[current]--;
            if(characters[current] >= 0)
            {
                required--;
            }

            while(required <= 0)
            {
                string sub = s.Substring(j, i - j + 1);
                if(sub.Length < result.Length || string.IsNullOrEmpty(result))
                {
                    result = sub;
                }
                char remove = s[j++];
                if (characters.ContainsKey(remove))
                {
                    characters[remove]++;
                    if (characters[remove] > 0)
                    {
                        required++;
                    }
                }
            }
        }

        return result;
    }
}
