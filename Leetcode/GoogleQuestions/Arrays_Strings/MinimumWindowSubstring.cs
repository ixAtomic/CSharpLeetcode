using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.GoogleQuestions.Arrays_Strings;

class MinimumWindowSubstring
{
    public string MinWindow(string s, string t)
    {
        Dictionary<char, int> characterList = GetCharacterCount(t);

        int i = 0;
        int j = 0;
        var theSubstring = "";
        Dictionary<char, int> currentValues = new Dictionary<char, int>();
        while (j < s.Length)
        {
            char c = s[j];
            if (currentValues.ContainsKey(c))
            {
                currentValues[c]++;
            }
            else
            {
                currentValues[c] = 1;
            }

            if(characterList.ContainsKey(c) && currentValues[c] == characterList[c])
            {
                //theSubstring.ins
            }

            while(i < j && theSubstring.Length == characterList.Count())
            {
                c = s[i];

            }

            j++;
        }

        return theSubstring;
    }

    Dictionary<char, int> GetCharacterCount(string theString)
    {
        Dictionary<char, int> characterList = new();

        foreach (char sub in theString)
        {
            if (characterList.ContainsKey(sub))
            {
                characterList[sub]++;
                continue;
            }

            characterList.Add(sub, 1);
        }

        return characterList;
    }
}
