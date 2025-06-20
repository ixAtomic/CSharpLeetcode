using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.GoogleQuestions.Arrays_Strings;

class KClosestPointsToOrigin
{
    public int[][] KClosest(int[][] points, int k)
    {
        PriorityQueue<int[], double> queue = new();
        List<int[]> results = new();
        foreach(var point in points)
        {
            var result = Math.Pow(point[0], 2) + Math.Pow(point[1], 2);
            queue.Enqueue(point, result);
        }

        for(var i = 0; i < k; i++)
        {
            var value = queue.Dequeue();
            results.Add(value);
        }

        return results.ToArray();
    }
}
