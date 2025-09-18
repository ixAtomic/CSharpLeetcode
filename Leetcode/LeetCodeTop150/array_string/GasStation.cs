using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.array_string;

public class GasStation
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {;
        int total = 0;
        int totalAfterMe = 0;
        int id = -1;
        for(int i = 0; i < gas.Length; i++)
        {
            int currentDifference = gas[i] - cost[i];
            total += currentDifference;
            totalAfterMe += currentDifference;

            if(currentDifference >= 0 && id == -1)
            {
                id = i;
            }

            if(totalAfterMe < 0)
            {
                totalAfterMe = 0;
                id = -1;
            }
        }

        return total >= 0 ? id : -1;
    }
}
