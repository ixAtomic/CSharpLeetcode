using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph.Kahns_Algorithm_For_Topological_Sorting;

//Kahns Algorithm
public class CourseScheduleII
{
    public int[] FindOrder(int numCourses, int[][] prerequisites)
    {
        Dictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();
        int[] inDegrees = new int[numCourses];
        for(int i = 0; i < numCourses; i++)
        {
            adjacencyList.Add(i, new List<int>());
            inDegrees[i] = 0;
        }

        foreach (var prereq in prerequisites)
        {
            var course = prereq[0];
            var pre = prereq[1];

            adjacencyList[pre].Add(course);
            inDegrees[course]++;
        }

        Queue<int> nodes = new Queue<int>();

        for (int i = 0; i < numCourses; i++)
        {
            if(inDegrees[i] == 0)
            {
                nodes.Enqueue(i);
            }
        }

        List<int> result = new();
        while(nodes.Count > 0)
        {
            var current = nodes.Dequeue();
            result.Add(current);    
            var neighbors = adjacencyList[current];

            foreach(var neighbor in neighbors)
            {
                inDegrees[neighbor]--;

                if (inDegrees[neighbor] == 0)
                {
                    nodes.Enqueue(neighbor);
                }
            }
        }

        if(result.Count != numCourses)
        {
            return [];
        }

        return result.ToArray();
    }
}
