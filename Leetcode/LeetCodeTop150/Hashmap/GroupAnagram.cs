using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.Hashmap;

public class GroupAnagram
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        int[] letters = new int[26];
        IList<IList<string>> result = [];
        int j = 0;
        while (j < strs.Length)
        {
            List<string> valid = new List<string>();
            string word = strs[j++];
            valid.Add(word);
            foreach(char c in word) //fill the dictionary with this words valid values
            {
                letters[c - 'a']++;
            }

            for (int i = j; i < strs.Length; i++)
            {
                if (strs[i].Length != word.Length)
                {
                    continue;
                }

                bool isValid = true;
                int[] check = new int[26];
                Array.Copy(letters, check, letters.Length);
                for(int k = 0; k < strs[i].Length; k++)
                {
                    char current = strs[i][k];

                    check[current - 'a']--;

                    if(check[current - 'a'] < 0)
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    valid.Add(strs[i]);
                    string temp = strs[j];
                    strs[j] = strs[i];
                    strs[i] = temp;
                    j++;
                }
            }
            result.Add(valid);
            Array.Clear(letters);
        }

        return result;
    }
}
