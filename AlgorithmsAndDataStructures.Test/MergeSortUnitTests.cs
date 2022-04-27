using Xunit;
using AlgorithmsAndDataStructures.Algorithms;

namespace AlgorithmsAndDataStructures.Test
{
    public class MergeSortUnitTests
    {
        private MergeSort mergeSort;
        public MergeSortUnitTests()
        {
            mergeSort = new MergeSort();
        }

        [Fact]
        public void UnorderedArray_Should_Be_Sorted()
        {
            /// Arrange
            int[] source = new int[] { 2,1,9,4,8,5,3,7,6 };
            int[] expected = new int[] { 1,2,3,4,5,6,7,8,9 };

            /// Act
            int[] result = mergeSort.Sort(source);

            /// Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void OrderedArray_Should_Be_Sorted()
        {
            /// Arrange
            int[] source = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            /// Act
            int[] result = mergeSort.Sort(source);

            /// Assert
            Assert.Equal(expected, result);
        }

    }
}