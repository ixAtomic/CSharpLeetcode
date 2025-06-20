using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.GoogleQuestions.Arrays_Strings;

class MeetingRooms2
{
    /// <summary>
    /// Attempt Again 
    /// </summary>
    /// <see href="https://leetcode.com/explore/interview/card/google/59/array-and-strings/3059/"/>
    public int MinMeetingRooms(int[][] intervals)
    {
        var sortedIntervals = intervals.OrderBy(x => x[0]);
        PriorityQueue<int, int> endTimes = new();

        foreach(var interval in sortedIntervals)
        {
            if(endTimes.Count == 0)
            {
                endTimes.Enqueue(interval[1], interval[1]);
                continue;
            }

            if(endTimes.Peek() >= interval[0])
            {
                endTimes.Enqueue(interval[1], interval[1]);
            }
        }

        return endTimes.Count;
    }
}
