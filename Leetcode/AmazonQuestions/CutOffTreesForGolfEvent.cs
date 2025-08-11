using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LeetCode.AmazonQuestions;

public class CutOffTreesForGolfEvent
{
    private List<Plot> _neighbors = new()
    {
        new(1, 0),
        new(-1, 0),
        new(0, 1),
        new(0, -1)
    };

    private record Plot(int x, int y);

    public int CutOffTree(IList<IList<int>> forest)
    {
        PriorityQueue<Plot, int> pq = new PriorityQueue<Plot, int>();
        for(int i = 0; i < forest.Count; i++)
        {
            for(int j = 0; j < forest[i].Count; j++)
            {
                if (forest[i][j] > 1)
                {
                    pq.Enqueue(new(i,j), forest[i][j]);
                }
            }
        }

        Plot prev = new(0,0);
        int distance = 0;
        while(pq.Count > 0)
        {
            var current = pq.Dequeue();
            var result = bfs(forest, prev, current);

            if(result == -1)
            {
                return result;
            }

            distance += result;
            prev = current;
        }

        return distance;
    }

    private int bfs(IList<IList<int>> forest, Plot start, Plot End)
    {
        Queue<(Plot plot, int count)> nodes = new Queue<(Plot plot, int count)>();
        HashSet<Plot> visited = new HashSet<Plot>();
        visited.Add(start);
        nodes.Enqueue((start, 0));

        while(nodes.Count > 0)
        {
            var current = nodes.Dequeue();

            if(current.plot == End)
            {
                return current.count;
            }

            foreach(var neighbor in _neighbors)
            {
                var cNeighbor = new Plot(current.plot.x + neighbor.x, current.plot.y + neighbor.y);

                if (visited.Contains(cNeighbor))
                {
                    continue;
                }

                if (cNeighbor.x > forest.Count - 1) continue;

                if (cNeighbor.y > forest[0].Count - 1) continue;

                if (cNeighbor.x < 0) continue;

                if (cNeighbor.y < 0) continue;

                if (forest[cNeighbor.x][cNeighbor.y] != 0)
                {
                    var c = current.count + 1;
                    visited.Add(cNeighbor);
                    nodes.Enqueue((cNeighbor, c));
                }
            }
        }

        return -1;
    }
}
