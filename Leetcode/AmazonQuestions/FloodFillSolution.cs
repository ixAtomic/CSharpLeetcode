using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AmazonQuestions;

public class FloodFillSolution
{
    private List<Plot> _neighbors = new()
    {
        new(1, 0),
        new(-1, 0),
        new(0, 1),
        new(0, -1)
    };

    private record Plot(int x, int y);

    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        if (image[sr][sc] == color)
        {
            return image;
        }

        Queue<Plot> nodes = new();
        nodes.Enqueue(new Plot(sr, sc));
        var colorToChange = image[sr][sc];
        image[sr][sc] = color;

        while (nodes.Any())
        {
            Plot plot = nodes.Dequeue();

            foreach(var neighbor in _neighbors)
            {
                var cNeighbor = new Plot(plot.x + neighbor.x, plot.y + neighbor.y);

                if(cNeighbor.x > image.Length - 1) continue;

                if(cNeighbor.y > image[0].Length - 1) continue;

                if(cNeighbor.x < 0) continue;

                if (cNeighbor.y < 0) continue;

                if (image[cNeighbor.x][cNeighbor.y] == colorToChange)
                {
                    nodes.Enqueue(cNeighbor);
                    image[cNeighbor.x][cNeighbor.y] = color;
                }
            }
        }

        return image;
    }
}
