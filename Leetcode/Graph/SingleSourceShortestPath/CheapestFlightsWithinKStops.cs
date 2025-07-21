using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph.SingleSourceShortestPath;


//Bellman Ford Implementation
public class CheapestFlightsWithinKStops
{
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
    {
        int[] previous = Enumerable.Repeat(int.MaxValue, n).ToArray();
        int[] current = Enumerable.Repeat(int.MaxValue, n).ToArray();
        previous[src] = 0;
        current[src] = 0;
        var stops = k + 1;
        while(stops > 0)
        {
            stops--;

            foreach (var flight in flights)
            {
                var from = flight[0];
                var to = flight[1];
                var cost = flight[2];

                if (previous[from] != int.MaxValue && previous[from] + cost < current[to])
                {
                    current[to] = previous[from] + cost;
                }
            }
            Array.Copy(current, previous, n);
            current = Enumerable.Repeat(int.MaxValue, n).ToArray();
            current[src] = 0;
        }

        return previous[dst] == int.MaxValue ? -1 : previous[dst];
    }
}
