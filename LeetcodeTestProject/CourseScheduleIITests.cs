using Xunit;

namespace LeetCode.Graph.Kahns_Algorithm_For_Topological_Sorting.Tests;

public class CourseScheduleIITests
{
    [Fact]
    public void FindOrder_TwoCourses_OnePrerequisite_ReturnsValidOrder()
    {
        // Arrange
        var solver = new CourseScheduleII();
        int numCourses = 2;
        int[][] prerequisites = new int[][] { new int[] { 1, 0 } };

        // Act
        var result = solver.FindOrder(numCourses, prerequisites);

        // Assert
        Assert.Equal(2, result.Length);
        Assert.Equal(0, result[0]);
        Assert.Equal(1, result[1]);
    }

    [Fact]
    public void FindOrder2_TwoCourses_OnePrerequisite_ReturnsValidOrder()
    {
        // Arrange
        var solver = new CourseScheduleII();
        int numCourses = 3;
        int[][] prerequisites = [[1, 0], [1, 2], [0, 1]];

        // Act
        var result = solver.FindOrder(numCourses, prerequisites);

        // Assert
        Assert.Empty(result);
    }
}