using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Agoda;

public class EliminateMaximumNumberOfMonsters
{
    public record Monster(int dist, int speed, int reach);

    public int EliminateMaximum(int[] dist, int[] speed)
    {
        PriorityQueue<Monster, int> pq = new PriorityQueue<Monster, int>();
        for(int i = 0; i < dist.Length; i++)
        {
            int timeToReach = (dist[i] + speed[i] - 1) / speed[i];

            var monster = new Monster(dist[i], speed[i], timeToReach);

            pq.Enqueue(monster, timeToReach);
        }

        int count = 0;
        for(int i = 0; i < dist.Length; i++)
        {
            var monster = pq.Dequeue();

            if(monster.reach <= i)
            {
                return count;
            }

            count++;
        }

        return count;
    }
}
