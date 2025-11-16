using System.Collections.Generic;
using LeetCode;
using LeetCode.LeetCodeTop150.LinkedLists;
using Xunit;

namespace LeetcodeTestProject.LeetCodeTop150.LinkedListsTests;

public class ReverseNodesInKGroupTests
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
    public void ReverseKGroup_KEquals2_ReversesPairs()
    {
        var head = BuildList(new[] { 1, 2, 3, 4, 5 });
        var solver = new ReverseNodesInKGroup();

        var result = solver.ReverseKGroup(head, 2);

        Assert.Equal(new[] { 2, 1, 4, 3, 5 }, ToArray(result));
    }

    [Fact]
    public void ReverseKGroup_KEquals3_ReversesTriplets_LeavesTail()
    {
        var head = BuildList(new[] { 1, 2, 3, 4, 5 });
        var solver = new ReverseNodesInKGroup();

        var result = solver.ReverseKGroup(head, 3);

        Assert.Equal(new[] { 3, 2, 1, 4, 5 }, ToArray(result));
    }

    [Fact]
    public void ReverseKGroup_KEquals1_NoChange()
    {
        var head = BuildList(new[] { 1, 2, 3 });
        var solver = new ReverseNodesInKGroup();

        var result = solver.ReverseKGroup(head, 1);

        Assert.Equal(new[] { 1, 2, 3 }, ToArray(result));
    }

    [Fact]
    public void ReverseKGroup_ListLengthMultipleOfK_ReversesAllGroups()
    {
        var head = BuildList(new[] { 1, 2, 3, 4, 5, 6 });
        var solver = new ReverseNodesInKGroup();

        var result = solver.ReverseKGroup(head, 3);

        Assert.Equal(new[] { 3, 2, 1, 6, 5, 4 }, ToArray(result));
    }

    [Fact]
    public void ReverseKGroup_KGreaterThanLength_NoChange()
    {
        var head = BuildList(new[] { 1, 2 });
        var solver = new ReverseNodesInKGroup();

        var result = solver.ReverseKGroup(head, 3);

        Assert.Equal(new[] { 1, 2 }, ToArray(result));
    }

    [Fact]
    public void ReverseKGroup_EmptyList_ReturnsNull()
    {
        ListNode head = null;
        var solver = new ReverseNodesInKGroup();

        var result = solver.ReverseKGroup(head, 2);

        Assert.Null(result);
    }

    [Fact]
    public void ReverseKGroup_ListLengthEqualsK_ReversesAll()
    {
        var head = BuildList(new[] { 1, 2, 3 });
        var solver = new ReverseNodesInKGroup();

        var result = solver.ReverseKGroup(head, 3);

        Assert.Equal(new[] { 3, 2, 1 }, ToArray(result));
    }
}
