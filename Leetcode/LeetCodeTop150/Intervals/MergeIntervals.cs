using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.Intervals;

public class MergeIntervals
{
    public int[][] Merge(int[][] intervals)
    {
        var sortedIntervals = intervals.OrderBy(x => x[0]).ToList(); //nlogn
        List<int[]> result = new List<int[]>();
        
        for (int i = 0; i < sortedIntervals.Count; i++)
        {
            if(result.Count == 0)
            {
                result.Add(sortedIntervals.ElementAt(i));
                continue;
            }

            int[] prev = result.Last();
            int[] current = sortedIntervals.ElementAt(i);
            if (prev[1] < current[0])
            {
                result.Add(current);
            }
            else if (prev[1] > current[1])
            {
                continue;
            }
            else
            {
                prev[1] = current[1];
            }
        }
        return result.ToArray();
    }
}
