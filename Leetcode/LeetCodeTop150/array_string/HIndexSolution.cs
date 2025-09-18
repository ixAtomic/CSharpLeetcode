using LeetCode.CapitalOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.array_string;

public class HIndexSolution
{
    public int HIndex(int[] citations)
    {
        //what if I sort? [0, 1, 3, 5, 6]
        Array.Sort(citations); //onlogn

        //I want to find the highest number that has a total that is >= itself remaining in the array.
        int highestH = 0;
        for (int i = 0; i < citations.Length; i++)
        {
            int citationNum = citations.Length - i;
            int currentHighest = citations[i] >= citationNum ? citationNum : citations[i];

            if(currentHighest > highestH)
            {
                highestH = currentHighest;
            }
        }

        return highestH;
    }
}
