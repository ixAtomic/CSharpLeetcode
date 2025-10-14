using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.Intervals;

public class InsertInterval
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        List<int[]> result = new List<int[]>();

        if (intervals.Length == 0)
        {
            result.Add(newInterval);
            return result.ToArray();
        }

        int[] value = [-1, -1];
        for (int i = 0; i < intervals.Length; i++)
        {
            if (value[1] != -1)
            {
                result.Add(intervals[i]);
                continue;
            }

            if (newInterval[0] < intervals[i][0] || newInterval[0] <= intervals[i][1])
            {
                value[0] = Math.Min(newInterval[0], intervals[i][0]);

                while (i + 1 < intervals.Length && newInterval[1] >= intervals[i][0] && newInterval[1] >= intervals[i][1])
                {
                    i++;
                }

                if (newInterval[1] < intervals[i][0])
                {
                    value[1] = newInterval[1];
                    result.Add(value);
                    result.Add(intervals[i]);
                }
                else
                {
                    value[1] = Math.Max(newInterval[1], intervals[i][1]);
                    result.Add(value);
                }
            }
            else
            {
                result.Add(intervals[i]);
            }
        }

        if (value[0] == -1)
        {
            result.Add(newInterval);
        }

        return result.ToArray();
    }
}
