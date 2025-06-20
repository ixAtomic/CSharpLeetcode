using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.GoogleQuestions.Arrays_Strings;

class MinimumCostToHireKWorkers
{
    public double MincostToHireWorkers(int[] quality, int[] wage, int k)
    {
        for(var i = 0; i < quality.Length; i++)
        {
            int j = i + 1;
            int currentQuality = quality[i];
            int currentWage = wage[i];
            while(j < (k + i) && (j + k) < quality.Length)
            {


                j++;
            }

            while (j < (k + i) && (j + k) < quality.Length)
            {


                j++;
            }
        }

        throw new NotImplementedException();
    }
}
