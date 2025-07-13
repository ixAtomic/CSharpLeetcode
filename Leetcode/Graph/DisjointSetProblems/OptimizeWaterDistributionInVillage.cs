using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LeetCode.Graph.DisjointSetProblems;

class OptimizeWaterDistributionInVillage
{
    public int MinCostToSupplyWater(int n, int[] wells, int[][] pipes)
    {
        var disjointSet = new DisjointSet(n);
        var weights = new Dictionary<(int x, int y), int>();
        foreach (var pipe in pipes)
        {
            var x = pipe[0];
            var y = pipe[1];
            var price = pipe[2];

            disjointSet.Union(x, y);
        }

        Dictionary<int, List<int>> rootToComponent = new Dictionary<int, List<int>>();
        for(int vertex = 0; vertex < n; vertex++)
        {
            var root = disjointSet.Find(vertex);
            if (!rootToComponent.ContainsKey(root))
                rootToComponent[root] = new List<int>();
            rootToComponent[root].Add(vertex);
        }

        var total = 0;
        foreach(var component in rootToComponent.Values)
        {
            foreach(var connectedHouse in component)
            {

            }
        }


        throw new NotImplementedException();
    }

    
}

