using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150;

public class ReverseWordsInAString
{
    public string ReverseWords(string s)
    {
        Stack<string> words = new Stack<string>();
        string word = string.Empty;
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == ' ')
            {
                if (!string.IsNullOrEmpty(word))
                {
                    words.Push(word);
                    word = string.Empty;
                }
            }
            else
            {
                word += s[i];
            }
        }
        
        if(!String.IsNullOrEmpty(word))
        {
            words.Push(word);
        }

        string result = string.Empty;
        while (words.Any())
        {
            result += words.Pop();

            if (words.Any())
            {
                result += ' ';
            }
        }

        return result;
    }
}
