using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LeetCode.CapitalOne;

public class FindOccurrencesOfAnElementInArray
{
    public int[] OccurrencesOfElement(int[] nums, int[] queries, int x)
    {
        int count = 1;
        Dictionary<int, int> set = new Dictionary<int, int>();
        //[1,3,1,7]
        //[1,3,2,4]

        for(int i = 0; i < nums.Length; i++) 
        {
            if (nums[i] == x)
            {
                set.Add(count, i);
                count++;
            }
        }
        
        for (int i = 0; i < queries.Length; i++)
        {
            if (set.ContainsKey(queries[i]))
            {
                queries[i] = set[queries[i]];
            }
            else
            {
                queries[i] = -1;
            }
        }

        return queries;
    }
}
