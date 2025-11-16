using System.Collections.Generic;
using LeetCode;
using LeetCode.LeetCodeTop150.LinkedLists;
using Xunit;

namespace LeetcodeTestProject.LeetCodeTop150.LinkedListsTests;

public class ReverseLinkedListIITests
{
    private static ListNode BuildList(int[] values)
    {
        var dummy = new ListNode(0, null);
        var tail = dummy;
        foreach (var v in values)
        {
            tail.next = new ListNode(v, null);
            tail = tail.next;
        }
        return dummy.next;
    }

    private static int[] ToArray(ListNode head)
    {
        var list = new List<int>();
        var cur = head;
        while (cur != null)
        {
            list.Add(cur.val);
            cur = cur.next;
        }
        return list.ToArray();
    }

    [Fact]
    public void ReverseBetween_MiddleSegment_ReversesCorrectly()
    {
        var head = BuildList(new[] { 1, 2, 3, 4, 5 });
        var solver = new ReverseLinkedListII();

        var result = solver.ReverseBetween(head, 2, 4);

        Assert.Equal(new[] { 1, 4, 3, 2, 5 }, ToArray(result));
    }

    [Fact]
    public void ReverseBetween_EntireList_ReversesAll()
    {
        var head = BuildList(new[] { 1, 2, 3, 4, 5 });
        var solver = new ReverseLinkedListII();

        var result = solver.ReverseBetween(head, 1, 5);

        Assert.Equal(new[] { 5, 4, 3, 2, 1 }, ToArray(result));
    }

    [Fact]
    public void ReverseBetween_HeadOnly_NoChange()
    {
        var head = BuildList(new[] { 1, 2, 3 });
        var solver = new ReverseLinkedListII();

        var result = solver.ReverseBetween(head, 1, 1);

        Assert.Equal(new[] { 1, 2, 3 }, ToArray(result));
    }

    [Fact]
    public void ReverseBetween_TailSegment_ReversesTail()
    {
        var head = BuildList(new[] { 1, 2, 3, 4, 5 });
        var solver = new ReverseLinkedListII();

        var result = solver.ReverseBetween(head, 4, 5);

        Assert.Equal(new[] { 1, 2, 3, 5, 4 }, ToArray(result));
    }

    [Fact]
    public void ReverseBetween_SingleElementList_NoChange()
    {
        var head = BuildList(new[] { 1 });
        var solver = new ReverseLinkedListII();

        var result = solver.ReverseBetween(head, 1, 1);

        Assert.Equal(new[] { 1 }, ToArray(result));
    }

    [Fact]
    public void ReverseBetween_LeftEqualsRightInMiddle_NoChange()
    {
        var head = BuildList(new[] { 1, 2, 3, 4 });
        var solver = new ReverseLinkedListII();

        var result = solver.ReverseBetween(head, 3, 3);

        Assert.Equal(new[] { 1, 2, 3, 4 }, ToArray(result));
    }
}
