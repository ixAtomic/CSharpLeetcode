using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.GoogleQuestions;

class ExpressiveWordsSolution
{
    public int ExpressiveWords(string s, string[] words)
    {
        Dictionary<char, int> groups = new();
        char prevChar = '\0';
        int streakCount = 1;

        foreach(var letter in s.Select((value, Index) => new { value, Index }))
        {
            if(letter.Index == 0)
            {
                prevChar = letter.value;
                continue;
            }

            if(letter.value == prevChar)
            {
                streakCount++;
            }
            else if(streakCount > 2)
            {
                groups.Add(prevChar, streakCount);
                streakCount = 1;
            }
            else
            {
                streakCount = 1;
            }

            prevChar = letter.value;
        }

        if(streakCount > 2)
        {
            groups.Add(prevChar, streakCount);
        }

        foreach (var word in words)
        {

        }

        return 0; 
    }
}
