using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeTop150.LinkedLists;

public class RemoveDuplicatesFromSortedListII
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        ListNode dummy = new ListNode(101, head);
        ListNode before = dummy;
        ListNode prev = dummy;
        ListNode current = dummy.next;
        bool isRun = false;

        while (current != null)
        {
            if (!isRun)
            {
                before = prev;
            }

            if (prev.val == current.val || current.val == current?.next?.val)
            {
                prev = current;
                current = prev.next;
                isRun = true;
                continue;
            }

            if (isRun)
            {
                before.next = current;
                before = current;
            }

            prev = current;
            current = current.next;
        }

        if (isRun)
        {
            before.next = current;
        }

        return dummy.next;
    }
}
