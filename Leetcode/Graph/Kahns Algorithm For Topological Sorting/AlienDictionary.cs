using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph.Kahns_Algorithm_For_Topological_Sorting;

//Failed
public class AlienDictionary
{
    public string AlienOrder(string[] words)
    {
        Dictionary<char, List<char>> adjacencyList = new Dictionary<char, List<char>>();
        Dictionary<char, int> inDegrees = new Dictionary<char, int>();

        bool letterExists = true;
        int i = 0;
        while (letterExists)
        {
            letterExists = false;

            foreach(var word in words)
            {
                if(word.Length <= i)
                {
                    continue;
                }

                var letter = word[i];
                if(!inDegrees.ContainsKey(letter))
                {
                    var cnt = inDegrees.Count;
                    inDegrees[letter] = cnt;
                }
                letterExists = true;
            }
            i++;
        }

        Queue<char> nodes = new Queue<char>();
        var nodeCount = inDegrees.Count;
        foreach (var key in inDegrees.Keys)
        {
            if (inDegrees[key] == 0)
            {
                inDegrees.Remove(key);
                nodes.Enqueue(key);
            }
        }
        
        List<char> result = [];
        while (nodes.Any())
        {
            var current = nodes.Dequeue();
            result.Add(current);

            foreach(var neighbor in adjacencyList[current])
            {
                inDegrees[neighbor]--;

                if (inDegrees[neighbor] == 0)
                {
                    nodes.Enqueue(neighbor);
                    inDegrees.Remove(neighbor);
                }
            }
        }

        if(nodeCount != result.Count)
        {
            return string.Empty;
        }

        return new string(result.ToArray());
    }
}
