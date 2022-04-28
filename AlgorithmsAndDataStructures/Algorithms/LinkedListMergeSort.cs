using AlgorithmsAndDataStructures.Data_Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList = AlgorithmsAndDataStructures.Data_Structures.LinkedList;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class LinkedListMergeSort
    {
        public LinkedList Sort(LinkedList source) {
            if (source.Size == 1 || source.Head == null)
                return source;

            var (left_half, right_half) = Split(source);
            var left = Sort(left_half);
            var right = Sort(right_half);

            return Merge(left, right);
        }

        private (LinkedList, LinkedList) Split(LinkedList source)
        {
            LinkedList left; 
            LinkedList right;
            if (source == null || source.Head == null)
            {
                left = source;
                right = null;
                return (left, right);
            }
             
            int size = source.Size;
            int mid = size / 2;
            Node midNode = source.NodeAtIndex(mid -1);
            left = source;
            right = new LinkedList(midNode.Next);
            midNode.Next = default;

            return (left, right);
        }

        private LinkedList Merge(LinkedList left, LinkedList right) {
            var merged = new LinkedList(new Node(0));

            var current = merged.Head;
            var leftHead = left.Head;
            var rightHead = right.Head;

            while (leftHead != null || rightHead != null)
            {
                if (leftHead == null) {
                    current.Next = rightHead;
                    rightHead = rightHead.Next;
                } else if (rightHead == null)
                {
                    current.Next = leftHead;
                    leftHead = leftHead.Next;
                } else if (leftHead.Data < rightHead.Data)
                {
                    current.Next = leftHead;
                    leftHead = leftHead.Next;
                } else {
                    current.Next = rightHead;
                    rightHead = rightHead.Next;
                }

                current = current.Next;
            }

            merged.Head = merged.Head.Next;

            return merged;
        }

        private void AssignAndMoveNext(Node source, Node target) {
            source.Next = target;
            target = target.Next;
        }

    }
}
