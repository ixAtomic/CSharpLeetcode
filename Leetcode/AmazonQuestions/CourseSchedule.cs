using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AmazonQuestions;

public class CourseSchedule
{
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        Dictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();
        List<int> inDegrees = new List<int>();

        for (int i = 0; i < numCourses; i++)
        {
            adjacencyList[i] = new List<int>();
            inDegrees.Add(0);
        }

        foreach(var prereq in prerequisites)
        {
            var course = prereq[0];
            var thePrereq = prereq[1];

            inDegrees[course]++;
            adjacencyList[thePrereq].Add(course);
        }

        Queue<int> nodes = new Queue<int>();
        for(int i = 0; i < numCourses; i++)
        {
            if (inDegrees[i] == 0)
            {
                nodes.Enqueue(i);
            }
        }

        while (nodes.Any())
        {
            var current = nodes.Dequeue();

            foreach(var neighbor in adjacencyList[current])
            {
                inDegrees[neighbor]--;

                if(inDegrees[neighbor] == 0)
                {
                    nodes.Enqueue(neighbor);
                }
            }
        }

        return !inDegrees.Exists(x => x != 0);
    }
}
