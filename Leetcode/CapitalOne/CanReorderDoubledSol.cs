using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CapitalOne;

public class CanReorderDoubledSol
{
    public bool CanReorderDoubled(int[] arr)
    {
        Dictionary<int, int> values = new Dictionary<int, int>();
        foreach (var value in arr)
        {
            if (values.ContainsKey(value))
            {
                values[value]++;
                continue;
            }

            values[value] = 1;
        }

        

        foreach (var key in values.Keys.ToList())
        {
            if (values[key] == 0)
            {
                continue;
            }

            var current = key * 2;

            if (values.ContainsKey(current))
            {
                if (values[key] != values[current])
                {
                    return false;
                }

                var matches = values[key];
                values[key] -= matches;
                values[current] -= matches;
            }
        }

        return values.Values.All(x => x == 0);
    }
}



