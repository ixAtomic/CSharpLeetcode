using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CapitalOne;

public class FindDistinctColorsAmongBalls
{
    public int[] QueryResults(int limit, int[][] queries)
    {
        List<int> result = new List<int>(queries.Length);
        // Use Dictionary for balls to avoid allocating large arrays when limit is big
        Dictionary<int, int> balls = new Dictionary<int, int>();
        int count = 0;
        Dictionary<int, int> colorCount = new Dictionary<int, int>();

        foreach (var query in queries)
        {
            int ball = query[0];
            int color = query[1];

            if (!balls.TryGetValue(ball, out int current))
            {
                balls[ball] = color;
                if (!colorCount.TryGetValue(color, out int c) || c == 0)
                {
                    colorCount[color] = 1;
                    count++;
                }
                else
                {
                    colorCount[color]++;
                }
            }
            else
            {
                colorCount[current]--;
                if (colorCount[current] == 0)
                {
                    count--;
                }

                if (!colorCount.TryGetValue(color, out int c) || c == 0)
                {
                    colorCount[color] = 1;
                    count++;
                }
                else
                {
                    colorCount[color]++;
                }
                balls[ball] = color;
            }

            result.Add(count);
        }

        return result.ToArray();
    }
}
