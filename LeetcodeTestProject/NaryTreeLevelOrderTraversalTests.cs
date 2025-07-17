using System.Collections.Generic;
using Xunit;
using LeetCode.Graph.BreadthFirstSearchProblems;

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

    [Fact]
    public void LevelOrder_ComplexTree_ReturnsExpected()
    {
        // Construct the tree manually based on the input serialization
        var node14 = new NNode(14, new List<NNode>());
        var node11 = new NNode(11, new List<NNode> { node14 });
        var node12 = new NNode(12, new List<NNode>());
        var node13 = new NNode(13, new List<NNode>());
        var node6 = new NNode(6, new List<NNode>());
        var node7 = new NNode(7, new List<NNode> { node11 });
        var node8 = new NNode(8, new List<NNode> { node12 });
        var node9 = new NNode(9, new List<NNode> { node13 });
        var node10 = new NNode(10, new List<NNode>());
        var node2 = new NNode(2, new List<NNode> { node6 });
        var node3 = new NNode(3, new List<NNode> { node7 });
        var node4 = new NNode(4, new List<NNode> { node8 });
        var node5 = new NNode(5, new List<NNode> { node9, node10 });
        var root = new NNode(1, new List<NNode> { node2, node3, node4, node5 });

        var traversal = new NaryTreeLevelOrderTraversal();
        var result = traversal.LevelOrder(root);

        var expected = new List<IList<int>>
        {
            new List<int> { 1 },
            new List<int> { 2, 3, 4, 5 },
            new List<int> { 6, 7, 8, 9, 10 },
            new List<int> { 11, 12, 13 },
            new List<int> { 14 }
        };

        Assert.Equal(expected.Count, result.Count);
        for (int i = 0; i < expected.Count; i++)
        {
            Assert.Equal(expected[i], result[i]);
        }
    }
}
