using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.LinkedLists
{
    public class PartitionList
    {
        public ListNode Partition(ListNode head, int x)
        {
            //two pointers where one points to the greater list and the other points to the less than list
            ListNode less = null;
            ListNode lessHead = null;
            ListNode greater = null;
            ListNode greaterHead = null;
            ListNode curr = head;
            while(curr != null)
            {
                ListNode next = curr.next;
                curr.next = null;
                if(curr.val < x)
                {
                    if(less == null)
                    {
                        lessHead = curr;
                        less = curr;
                    }
                    else
                    {
                        less.next = curr;
                        less = less.next;
                    }
                }
                else
                {
                    if (greater == null) 
                    {
                        greaterHead = curr;
                        greater = curr;
                    }
                    else
                    {
                        greater.next = curr;
                        greater = greater.next;
                    }
                }
                
                curr = next;
            }

            if(less != null)
            {
                less.next = greaterHead;
            }
                

            return lessHead == null ? greaterHead : lessHead;
        }
    }
}
