using LeetCode.Graph.BreadthFirstSearchProblems;
using System.Collections.Generic;
using System.Xml.Linq;
using Xunit;

public class NaryTreeLevelOrderTraversalTests
{
    [Fact]
    public void LevelOrder_GivenSampleTree_ReturnsExpectedResult()
    {
        // Construct the tree: [1,null,3,2,4,null,5,6]
        var root = new NNode(1, new List<NNode>
        {
            new NNode(3, new List<NNode>
            {
                new NNode(5),
                new NNode(6)
            }),
            new NNode(2),
            new NNode(4)
        });

        var traversal = new NaryTreeLevelOrderTraversal();
        var result = traversal.LevelOrder(root);

        var expected = new List<IList<int>>
        {
            new List<int> { 1 },
            new List<int> { 3, 2, 4 },
            new List<int> { 5, 6 }
        };

        Assert.Equal(expected.Count, result.Count);
        for (int i = 0; i < expected.Count; i++)
        {
            Assert.Equal(expected[i], result[i]);
        }
    }
}
