using LeetCode.LeetCodeTop150;
using LeetCode.LeetCodeTop150.array_string;
using Xunit;

namespace LeetcodeTestProject.LeetCodeTop150.array_string_tests
{
    public class TextJustificationTests
    {
        [Fact]
        public void FullJustify_Input_Example1_Returns_Expected()
        {
            // Arrange
            var solution = new TextJustification();
            string[] words = { "This", "is", "an", "example", "of", "text", "justification." };
            int maxWidth = 16;

            // Act
            var result = solution.FullJustify(words, maxWidth);

            // Assert
            // The expected output is based on standard LeetCode justification for this input.
            var expected = new[]
            {
                "This    is    an",
                "example  of text",
                "justification.  "
            };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void FullJustify_Input_WhatMustBeAcknowledgmentShallBe_Returns_Expected()
        {
            // Arrange
            var solution = new TextJustification();
            string[] words = { "What", "must", "be", "acknowledgment", "shall", "be" };
            int maxWidth = 16;

            // Act
            var result = solution.FullJustify(words, maxWidth);

            // Assert
            var expected = new[]
            {
                "What   must   be",
                "acknowledgment  ",
                "shall be        "
            };
            Assert.Equal(expected, result);
        }
    }
}