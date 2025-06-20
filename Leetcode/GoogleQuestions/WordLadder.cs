using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LeetCode.GoogleQuestions;

public class WordLadder
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        if (!wordList.Contains(endWord))
        {
            return 0;
        }

        wordList.Add(beginWord);

        var visited = new HashSet<string>();
        var nodes = new PriorityQueue<string, int>();
        var Previous = new Dictionary<string, string?>();
        var CurrentShortestPath = new Dictionary<string, int>();

        Previous[endWord] = null;
        CurrentShortestPath[endWord] = 1;
        nodes.Enqueue(endWord, 1);
        visited.Add(endWord);

        while(nodes.Count > 0)
        {
            var current = nodes.Dequeue();
            var CloseWords = new List<string>();

            foreach(var word in wordList)
            {
                var differences = 0;
                for(var i = 0; i < current.Length; i++)
                {
                    if (word[i] != current[i])
                    {
                        differences++;
                    }
                }

                if(differences == 1)
                {
                    CloseWords.Add(word);
                }
            }

            foreach(var closeWord in CloseWords)
            {
                var total = CurrentShortestPath[current] + 1;

                if (!visited.Contains(closeWord))
                {
                    nodes.Enqueue(closeWord, total);
                    visited.Add(closeWord);
                }

                if (!CurrentShortestPath.ContainsKey(closeWord))
                {
                    CurrentShortestPath[closeWord] = total;
                    Previous[closeWord] = current;
                    continue;
                }

                if (CurrentShortestPath[closeWord] > total)
                {
                    CurrentShortestPath[closeWord] = total;
                    Previous[closeWord] = current;
                    continue;
                }
            }
        }

        if (!CurrentShortestPath.ContainsKey(beginWord))
        {
            return 0;
        }

        return CurrentShortestPath[beginWord];
    }
}
