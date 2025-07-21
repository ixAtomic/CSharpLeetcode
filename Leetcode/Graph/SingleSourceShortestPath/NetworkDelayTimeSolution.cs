using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph.SingleSourceShortestPath;

public class NetworkDelayTimeSolution
{
    public int NetworkDelayTime(int[][] times, int n, int k)
    {
        Dictionary<int, List<signal>> adjacencyList = new Dictionary<int, List<signal>>();

        for (var i = 1; i <= n; i++)
        {
            adjacencyList[i] = new List<signal>();
        }

        foreach (var t in times)
        {
            int from = t[0];
            int to = t[1];
            int time = t[2];

            adjacencyList[from].Add(new signal(to, time));
        }

        HashSet<int> visited = new HashSet<int>();
        Dictionary<int, int?> previous = new Dictionary<int, int?>();
        Dictionary<int, int> shortestPath = new Dictionary<int, int>();
        PriorityQueue<int, int> queue = new PriorityQueue<int, int>();

        previous[k] = null;
        shortestPath[k] = 0;
        visited.Add(k);
        queue.Enqueue(k, 0);

        while(queue.Count > 0)
        {
            var index = queue.Dequeue();
            var current = adjacencyList[index];
            visited.Add(index);

            foreach (var signal in current)
            {
                var weight = shortestPath[index] + signal.time;

                if (!visited.Contains(signal.to))
                {
                    queue.Enqueue(signal.to, weight);
                }

                if (!shortestPath.ContainsKey(signal.to))
                {
                    shortestPath[signal.to] = weight;
                    previous[signal.to] = index;
                    continue;
                }

                if (shortestPath[signal.to] > weight)
                {
                    shortestPath[signal.to] = weight; 
                    previous[signal.to] = index;
                    continue;
                }
            }
        }

        if(visited.Count != n)
        {
            return -1; //we were not able to find all nodes
        }

        return shortestPath.Values.OrderByDescending(x => x).First();
    }

    private record signal(int to, int time);
}
