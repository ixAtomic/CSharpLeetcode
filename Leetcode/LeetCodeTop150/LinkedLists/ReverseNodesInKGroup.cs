using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.LinkedLists;

public class ReverseNodesInKGroup
{
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        ListNode dummy = new ListNode(0, head);
        ListNode before = dummy;
        int count = 1;

        while(head is not null)
        {
            count++;
            head = head.next;
        }

        int iter = 1;
        ListNode prev = before;
        ListNode curr = before.next;
        while (curr != null)
        {
            if(iter + k > count)
            {
                break;
            }

            for (int i = 0; i < k; i++)
            {
                ListNode next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
                iter++;
            }

            before.next.next = curr;
            ListNode temp = before.next;
            before.next = prev;
            before = temp;
        }

        return dummy.next;
    }
}
