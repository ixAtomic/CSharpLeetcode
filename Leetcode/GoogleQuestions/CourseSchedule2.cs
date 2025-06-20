using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LeetCode.GoogleQuestions;

public class CourseSchedule2
{
    public int[] FindOrder(int numCourses, int[][] prerequisites)
    {
        Dictionary<int, List<int>> adjacencyList = new();
        HashSet<int> visited = new();
        HashSet<int> order = new();

        foreach(var prereq in prerequisites)
        {
            var key = prereq[0];
            var value = prereq[1];

            if (!adjacencyList.ContainsKey(key))
            {
                adjacencyList.Add(key, new());
            }

            adjacencyList[key].Add(value);
        }

        for(var i = 0; i < numCourses; i++)
        {
            if (visited.Contains(i))
            {
                continue;
            }

            if (!adjacencyList.ContainsKey(i))
            {
                visited.Add(i);
                continue;
            }

            foreach(var node in adjacencyList[i])
            {
                visited = DFS(node, adjacencyList, visited);
            }

            visited.Add(i);
        }

        Console.WriteLine(JsonSerializer.Serialize(visited));
        return visited.ToArray();
    }

    private HashSet<int> DFS(int key, Dictionary<int, List<int>> adjacencyList, HashSet<int> visited)
    {
        foreach(var node in adjacencyList[key])
        {
            if (!visited.Contains(node))
            {
                visited = DFS(node, adjacencyList, visited);
            }
        }

        visited.Add(key);
        return visited;
    }
}
