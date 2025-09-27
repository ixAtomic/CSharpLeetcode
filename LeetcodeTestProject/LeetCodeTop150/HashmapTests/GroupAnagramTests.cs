using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.LeetCodeTop150.Hashmap;

namespace LeetcodeTestProject.LeetCodeTop150.HashmapTests;

public class GroupAnagramTests
{
    [Fact]
    public void Valid_GroupAnagram()
    {
        // Arrange
        var input = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
        var expected = new List<IList<string>>
        {
            new List<string> { "eat", "tea", "ate" },
            new List<string> { "tan", "nat" },
            new List<string> { "bat" }
        };

        var solver = new GroupAnagram();

        // Act
        var result = solver.GroupAnagrams(input);

        // Assert
        // We need to compare ignoring order of groups and order inside groups
        foreach (var group in expected)
        {
            Assert.Contains(result, r =>
                new HashSet<string>(r).SetEquals(group));
        }

        Assert.Equal(expected.Count, result.Count);
    }
}
