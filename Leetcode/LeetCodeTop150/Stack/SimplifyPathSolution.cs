using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.Stack;

public class SimplifyPathSolution
{
    public string SimplifyPath(string path)
    {
        Stack<string> simple = new Stack<string>();
        simple.Push("/");
        string current = string.Empty;
        foreach(var c in path)
        {
            if(c == '/')
            {
                if(simple.Peek() == "/" && string.IsNullOrEmpty(current))
                {
                    continue;
                }

                simple = updateDirectory(current, simple);
                current = string.Empty;
            }
            else
            {
                current += c;
            }
        }

        if (!string.IsNullOrEmpty(current))
        {
            simple = updateDirectory(current, simple);
        }
        
        if(simple.Peek() == "/" && simple.Count > 1)
        {
            simple.Pop();
        }

        string result = string.Empty;
        while (simple.Any())
        {
            result = simple.Pop() + result;
        }

        return result;
    }

    private Stack<string> updateDirectory(string value, Stack<string> update)
    {
        if (value == "..")
        {
            if (update.Count() > 1)
            {
                update.Pop();
                update.Pop();
            }
            
            return update;
        }

        if (value == ".")
        {
            return update;
        }


        update.Push(value);
        update.Push("/");
        return update;
    }
}
