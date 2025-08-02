using Xunit;
using LeetCode.Graph.Kahns_Algorithm_For_Topological_Sorting;

public class AlienDictionaryTests
{
    [Fact]
    public void AlienOrder_ExampleInput_ReturnsExpectedOrder()
    {
        // Arrange
        var solver = new AlienDictionary();
        string[] words = { "wrt", "wrf", "er", "ett", "rftt" };
        string expected = "wertf";

        // Act
        string result = solver.AlienOrder(words);

        // Assert
        Assert.Equal(expected, result);
    }
}