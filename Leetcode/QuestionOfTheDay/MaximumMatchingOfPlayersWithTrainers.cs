using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QuestionOfTheDay;

public class MaximumMatchingOfPlayersWithTrainers
{
    public int MatchPlayersAndTrainers(int[] players, int[] trainers)
    {
        var playerPrio = new PriorityQueue<int, int>();
        var trainerPrio = new PriorityQueue<int, int>();

        foreach (var player in players)
        {
            playerPrio.Enqueue(player, player);
        }

        foreach (var trainer in trainers)
        {
            trainerPrio.Enqueue(trainer, trainer);
        }

        var count = 0;
        while (trainerPrio.Count > 0 && playerPrio.Count > 0)
        {
            var currentPlayer = playerPrio.Peek();
            var currrentTrainer = trainerPrio.Peek();

            if (currentPlayer <= currrentTrainer)
            {
                count++;
                playerPrio.Dequeue();
                trainerPrio.Dequeue();
            }
            else
            {
                trainerPrio.Dequeue();
            }
        }

        return count;
    }
}
