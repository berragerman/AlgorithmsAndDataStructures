using AlgorithmsAndDataStructures.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using LinkedList = AlgorithmsAndDataStructures.Data_Structures.LinkedList;

namespace AlgorithmsAndDataStructures.Test
{
    public class LinkedListMergeSortUnitTests
    {
        private LinkedListMergeSort linkedListMergeSort;
        public LinkedListMergeSortUnitTests()
        {
            linkedListMergeSort = new LinkedListMergeSort();
        }

        [Fact]
        public void UnorderedLinkedList_Should_Be_Ordered() {

            /// Arrange
            LinkedList source = new LinkedList(); 
            source.Add(6);
            source.Add(7);
            source.Add(3);
            source.Add(5);
            source.Add(8);
            source.Add(4);
            source.Add(9);
            source.Add(1);
            source.Add(2);

            LinkedList expected = new LinkedList();
            expected.Add(9);
            expected.Add(8);
            expected.Add(7);
            expected.Add(6);
            expected.Add(5);
            expected.Add(4);
            expected.Add(3);
            expected.Add(2);
            expected.Add(1);

            /// Act
            LinkedList result = linkedListMergeSort.Sort(source);

            /// Assert
            Assert.Equal(expected.ToString(), result.ToString());

        }
    }
}
