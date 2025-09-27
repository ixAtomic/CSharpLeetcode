using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.Hashmap;

public class WordPatternSolution
{
    public bool WordPattern(string pattern, string s)
    {
        var words = s.Split(' ');
        Dictionary<char, string> patternSet = new Dictionary<char, string>();
        Dictionary<string, char> wordSet = new Dictionary<string, char>();

        if (pattern.Length != words.Length) return false;

        for (int i = 0; i < pattern.Length; i++)
        {
            char c = pattern[i];
            string word = words[i];
            if (!patternSet.ContainsKey(c))
            {
                patternSet.Add(c, word);
                continue;
            }

            if (patternSet[c] != word)
            {
                return false;
            }
        }

        for(int i = 0; i < words.Length; i++)
        {
            char c = pattern[i];
            string word = words[i];
            if (!wordSet.ContainsKey(word))
            {
                wordSet.Add(word, c);
                continue;
            }

            if (wordSet[word] != c)
            {
                return false;
            }
        }

        return true;
    }
}
