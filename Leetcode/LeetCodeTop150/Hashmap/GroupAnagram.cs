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
        Dictionary<string, IList<string>> result = new Dictionary<string, IList<string>>();
        foreach (var str in strs)
        {
            char[] chars = new char[26];

            foreach (var c in str)
            {
                chars[c - 'a']++;
            }

            string key = new string(chars);

            if (!result.ContainsKey(key))
            {
                result[key] = new List<string>();
            }
            result[key].Add(str);
        }

        return result.Values.ToList();
    }
}
