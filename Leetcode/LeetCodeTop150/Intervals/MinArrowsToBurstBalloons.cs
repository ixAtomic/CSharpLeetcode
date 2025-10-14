using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.Intervals;

public class MinArrowsToBurstBalloons
{
    public int FindMinArrowShots(int[][] points)
    {
        var sorted = points.OrderBy(p => p[1]).ToList();
        int endpoint = sorted[0][1];
        int count = 1;
        for(int i = 1; i < sorted.Count; i++)
        {
            if (endpoint < sorted[i][1]) //they dont overlap
            {
                endpoint = sorted[i][1];
                count++;
            }
        }

        return count;
    }
}
