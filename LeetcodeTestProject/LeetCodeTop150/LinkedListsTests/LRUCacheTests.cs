using LeetCode.LeetCodeTop150.LinkedLists;
using Xunit;

namespace LeetcodeTestProject.LeetCodeTop150.LinkedListsTests;

public class LRUCacheTests
{
    [Fact]
    public void Get_ReturnsMinusOne_WhenKeyNotPresent()
    {
        var cache = new LRUCache(2);
        Assert.Equal(-1, cache.Get(10));
    }

    [Fact]
    public void Put_ThenGet_ReturnsStoredValue()
    {
        var cache = new LRUCache(2);
        cache.Put(1, 100);
        Assert.Equal(100, cache.Get(1));
    }

    [Fact]
    public void Put_UpdateExistingKey_ChangesValue()
    {
        var cache = new LRUCache(2);
        cache.Put(1, 10);
        cache.Put(1, 99); // update
        Assert.Equal(99, cache.Get(1));
    }

    [Fact]
    public void EvictsLeastRecentlyUsed_AfterCapacityExceeded_SimpleSequence()
    {
        var cache = new LRUCache(2);
        cache.Put(1, 1); // cache: 1
        cache.Put(2, 2); // cache: 1,2
        cache.Put(3, 3); // should evict key 1 (LRU) if implemented correctly

        Assert.Equal(-1, cache.Get(1));
        Assert.Equal(2, cache.Get(2));
        Assert.Equal(3, cache.Get(3));
    }

    [Fact]
    public void AccessingKey_MakesItMostRecent_BeforeEviction()
    {
        var cache = new LRUCache(2);
        cache.Put(1, 1);      // 1
        cache.Put(2, 2);      // 1,2 (2 MRU)
        Assert.Equal(1, cache.Get(1)); // access 1 -> 1 becomes MRU (expected in correct LRU)
        cache.Put(3, 3);      // should evict key 2 if recency updated

        // Expected for fully correct LRU implementation:
        Assert.Equal(-1, cache.Get(2));
        Assert.Equal(1, cache.Get(1));
        Assert.Equal(3, cache.Get(3));
    }

    [Fact]
    public void MultipleEvictions_WorkAcrossSequence()
    {
        var cache = new LRUCache(2);
        cache.Put(1, 1); // 1
        cache.Put(2, 2); // 1,2
        cache.Put(3, 3); // evict 1 -> 2,3
        cache.Put(4, 4); // evict 2 -> 3,4

        Assert.Equal(-1, cache.Get(1));
        Assert.Equal(-1, cache.Get(2));
        Assert.Equal(3, cache.Get(3));
        Assert.Equal(4, cache.Get(4));
    }
}
