using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.GoogleQuestions;

class GuessTheWord
{ 
    class Solution
    {

        //not working
        public void FindSecretWord(string[] words, Master master)
        {
            HashSet<string> visited = new();
            var filteredWords = words;
            while(true)
            {
                var current = filteredWords.First();
                visited.Add(current);
                var total = master.Guess(current);

                if(total == 6)
                {
                    return;
                }

                filteredWords = filteredWords.Where(x =>
                {
                    if(total == 0)
                    {
                        return x.Intersect(current).Count() == 0 && !visited.Contains(x);
                    }

                    return x.Intersect(current).Count() >= total && !visited.Contains(x);
                }).ToArray();
            }
        }
    }
}

// This is the Master's API interface.
// You should not implement it, or speculate about its implementation
public interface Master
{
    public int Guess(string word);
}
