using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.Stack;

public class ValidParenthesis
{
    Dictionary<char, char> characters = new()
    {
        { '(', ')' },
        { '[', ']' },
        { '{', '}' }
    };
    public bool IsValid(string s)
    {
        Stack<char> chars = new Stack<char>();
        foreach(var c in s)
        {
            if (characters.ContainsKey(c))
            {
                chars.Push(characters[c]);
            }
            else
            {
                if(chars.Count == 0 || c != chars.Pop())
                {
                    return false;
                }
            }
        }

        return chars.Count < 0;
    }
}
