using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Data_Structures
{
    public class Node {

        public int Data;
        public Node? Next;

        public Node(int data)
        {
            this.Data = data;
        }

        public override string ToString()
        {
            return $"<Node data: {Data}>";
        }
    }
    public class LinkedList
    {
        public Node Head;

        public LinkedList(Node head)
        {
            this.Head = head;

        }

        public bool IsEmpty {
            get => this.Head == null;
        }

        // Takes O(n) times
        public int Size {
            get {
                int size = 0;
                Node current = this.Head;

                while (current.Next != null) { 
                    size++;
                    current = current.Next;
                }

                return size;
            }
        }

        // Takes O(1) Time
        public void Add(int data) { 
            Node newNode = new Node(data);
            newNode.Next = this.Head;
            this.Head = newNode;
        }

        // Takes O(n) times
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();            
            sb.Append($"[Head: {this.Head.Data}]");

            Node current = this.Head;
            while (current != null)
            {
                if (current.Next != null)
                {
                    sb.Append($" -> {current.Data}");
                }
                else 
                {
                    sb.Append($" -> [Tail: {current.Data}]");
                }
            }

            return sb.ToString();
        }

        // Take O(n) times
        public Node? Search(int data)
        {
            Node? current = this.Head;

            while (current != null)
            {
                if (current.Data == data)
                    return current;

                current = current.Next;
            }

            return default;
        }

        /*
            Insert Takes O(1) but Search takes O(n)
            Overall O(n)
         */
        public void Insert(int data, int index)
        {
            if (index == 0)
            {
                this.Add(data);
            }

            if (index > 0)
            {
                Node newNode = new Node(data);
        
                int possition = index;
                Node current = this.Head;

                while (possition > 1) {
                    current = current.Next;
                    possition--;
                }

                Node prev = current;
                Node next = current.Next;

                prev.Next = newNode;
                newNode.Next = next;

            }

        }

        // Takes O(n) times
        public Node Remove(int data) {
            Node current = this.Head;
            Node previous = default;
            bool found = false;

            while (current != null && !found)
            {
                if (current.Data == data && current == Head)
                {
                    found = true;
                    Head = current.Next;
                }
                else if (current.Data == data)
                {
                    previous.Next = current.Next;
                    found = true;
                }
                else {
                    previous = current;
                    current = current.Next;
                }
            }

            return current;

        }

        public Node NodeAtIndex(int index) {
            if (index == 0)
                return this.Head;
            else { 
                Node current = this.Head;
                int position = 0;

                while (position < index)
                {
                    current = current.Next;
                    position++;
                }

                return current;
            }
        }

    }
}
