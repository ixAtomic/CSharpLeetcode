using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph.DisjointSetProblems;

class TheEarliestMomentWhenEvery1BecomesFriends
{
    public int EarliestAcq(int[][] logs, int n)
    {
        var disjointSet = new DisjointSet(n);
        var sortedLogs = logs.OrderBy(x => x[0]).ToArray();

        for(int i = 0; i < sortedLogs.Length; i++)
        {
            var timestamp = sortedLogs[i][0];
            var x = sortedLogs[i][1];
            var y = sortedLogs[i][2];

            disjointSet.Union(x, y);
            if(disjointSet.RootsCount() == 1)
            {
                return timestamp;
            }
        }

        return -1;
    }
}
