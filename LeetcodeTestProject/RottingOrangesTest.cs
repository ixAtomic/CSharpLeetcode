using Xunit;
using LeetCode.Graph.BreadthFirstSearchProblems;

namespace LeetcodeTestProject
{
    public class RottingOrangesTest
    {
        [Fact]
        public void OrangesRotting_ExampleCase_ReturnsExpected()
        {
            var grid = new int[][]
            {
                new int[] { 2, 1, 1 },
                new int[] { 1, 1, 0 },
                new int[] { 0, 1, 1 }
            };

            var solver = new RottingOranges();
            int result = solver.OrangesRotting(grid);

            Assert.Equal(4, result);
        }

        [Fact]
        public void OrangesRotting_ExampleCase2_ReturnsExpected()
        {
            var grid = new int[][]
            {
                new int[] { 0, 2 },
            };

            var solver = new RottingOranges();
            int result = solver.OrangesRotting(grid);

            Assert.Equal(0, result);
        }

        [Fact]
        public void OrangesRotting_ExampleCaseEmptyGrid_ReturnsExpected()
        {
            var grid = new int[][]
            {
            };

            var solver = new RottingOranges();
            int result = solver.OrangesRotting(grid);

            Assert.Equal(0, result);
        }


        [Fact]
        public void OrangesRotting_ExampleCase4_ReturnsExpected()
        {
            var grid = new int[][]
            {
                new int[] { 2, 1, 1 },
                new int[] { 0, 1, 1 },
                new int[] { 1, 0, 1 }
            };

            var solver = new RottingOranges();
            int result = solver.OrangesRotting(grid);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void OrangesRotting_ExampleCase5_ReturnsExpected()
        {
            var grid = new int[][]
            {
                new int[] { 2, 1, 1 },
                new int[] { 1, 1, 1 },
                new int[] { 0, 1, 2 }
            };

            var solver = new RottingOranges();
            int result = solver.OrangesRotting(grid);

            Assert.Equal(2, result);
        }
        
    }
}