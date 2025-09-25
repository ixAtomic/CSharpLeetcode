using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.SlidingWindow;

public class SubstringWithConcantenationOfAllWords
{
    private int validLength ;
    public IList<int> FindSubstring(string s, string[] words)
    {
        int validLength = words.Length * words[0].Length;
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        for(int i = 0; i < words.Length; i++)
        {
            if (!wordCount.ContainsKey(words[i]))
            {
                wordCount.Add(words[i], 0);
            }

            wordCount[words[i]]++;
        }

        for (int i = 0; i < words[0].Length; i++)
        {

        }

        throw new NotImplementedException();
    }

    private IList<int> slidingWindow(int left, string s)
    {
        throw new NotImplementedException();
    }
}
