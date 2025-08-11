using System;
using Xunit;
using LeetCode.AmazonQuestions;

namespace LeetcodeTestProject.AmazonQuestionsTests;

public class CourseScheduleTests
{
    [Fact]
    public void CanFinish_TwoCoursesOnePrerequisite_ReturnsTrue()
    {
        // Arrange
        var courseSchedule = new CourseSchedule();
        int numCourses = 2;
        int[][] prerequisites = new int[][] { new int[] { 1, 0 } };

        // Act
        bool result = courseSchedule.CanFinish(numCourses, prerequisites);

        // Assert
        Assert.True(result);
    }
}