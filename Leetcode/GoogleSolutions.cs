using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;

public class GoogleSolutions
{
    public int NumUniqueEmails(string[] emails)
    {
        HashSet<string> reducedEmails = new HashSet<string>();
        foreach(var email in emails)
        {
            var split = email.Split('@');
            var local = split[0];
            var domain = split[1];

            var separatePlus = local.Split('+');
            var reducedLocal = separatePlus[0];

            reducedLocal = reducedLocal.Replace(".", "");

            var reducedEmail = $"{reducedLocal}@{domain}";

            if (reducedEmails.Contains(reducedEmail))
            {
                continue;
            }

            reducedEmails.Add(reducedEmail);
        }

        return reducedEmails.Count();
    }

    //get maximum value and always get closer by removing the lower number from the list
    //Difficulty: Med
    public int ContainerWithMostWater(int[] height)
    {
        int maxNumber = 0;
        int i = 0;
        int j = height.Length - 1;
        while (i < j)
        {
            int distance = j - i;
            int compareValue;
            if (height[i] > height[j])
            {
                compareValue = height[j];
                j--;
            }
            else
            {
                compareValue = height[i];
                i++;
            }

            var result = compareValue * distance;

            if(maxNumber < result)
            {
                maxNumber = result;
            }
        }

        return maxNumber;
    }

    //sliding window move to the end and track the biggest gap streak
    //Difficulty: Medium
    public int MaxDistToClosestPerson(int[] seats)
    {
        int maxDistance = 0;
        int currentDistance = 0;
        int i = 0;
        while (i < seats.Length)
        {
            if (seats[i] == 1)
            {
                if ((i - currentDistance) == 0 && i != 0)
                {
                    maxDistance = maxDistance > currentDistance ? maxDistance : currentDistance;
                }
                else
                {
                    var calc = (currentDistance + 1) / 2;
                    maxDistance = maxDistance > calc ? maxDistance : calc;
                }

                currentDistance = 0;
            }
            else
            {
                currentDistance++;
            }

            i++;
        }

        return maxDistance > currentDistance ? maxDistance : currentDistance;
    }

    //runner pattern
    //unable to complete
    //Difficulty: Hard
    //probably need to look up heap and priority queue's
    public double MincostToHireWorkers(int[] quality, int[] wage, int k)
    {
        var minTotal = int.MaxValue;


        throw new NotImplementedException();
    }

    //Difficulty: Med
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode? First = l1;
        ListNode? Second = l2;
        ListNode Head = new ListNode();
        ListNode? Result = null;

        var carryOver = 0;

        while (First is not null || Second is not null || carryOver != 0)
        {
            if(Result is null)
            {
                Result = Head;
            }
            else
            {
                Result.next = new ListNode();
                Result = Result.next;
            }

            var total = (First?.val ?? 0) + (Second?.val ?? 0) + carryOver;

            carryOver = total / 10;

            var result = total % 10;

            Result.val = result;

            First = First?.next;
            Second = Second?.next;
        }

        return Head;
    }

    public int NumIslands(char[][] grid)
    {


        throw new NotImplementedException();
    }
}


public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }

    public ListNode createList(List<int> values)
    {
        var Head = new ListNode();
        ListNode? Current = null;
        foreach(var value in values)
        {
            if (Current is null)
            {
                Current = Head;
            }
            else
            {
                Current.next = new ListNode();
                Current = Current.next;
            }

            Current.val = value;
        }

        return Head;
    }
}

