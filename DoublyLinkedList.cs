using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class DoublyLinkedList
    {
        private class Node
        {
            public Node(int value)
            {
                Value = value;
                Next = null;
                Prev = null;
            }
            public Node Prev { get; set; }
            public int Value { get; set; }
            public Node Next { get; set; }
        }

        private Node head;
        private Node tail;
        private int length;

        public DoublyLinkedList()
        {
            length = 0;
        }

        public int Get(int index)
        {
            if (index < 0 || index >= length)
            {
                return -1; // Index out of bounds
            }
            return GetNodeAtIndex(index).Value;
        }

        public void AddAtHead(int val)
        {
            var nodeToInsert = new Node(val);
            if (head == null)
            {
                head = tail = nodeToInsert;
            }
            else
            {
                nodeToInsert.Next = head;
                head.Prev = nodeToInsert;
                head = nodeToInsert;
            }
            length++;
        }

        public void AddAtTail(int val)
        {
            var nodeToInsert = new Node(val);
            if (head == null)
            {
                head = tail = nodeToInsert;
            }
            else
            {
                nodeToInsert.Prev = tail;
                tail.Next = nodeToInsert;
                tail = nodeToInsert;
            }
            length++;
        }

        public void AddAtIndex(int index, int val)
        {
            if (index == 0)
            {
                AddAtHead(val);
                return;
            }else if (index == length)
            {
                AddAtTail(val);
                return;
            }
            else if (index > length)
            {
                return;
            }
            var pointer = GetNodeAtIndex(index);
            var nodeToInsert = new Node(val);
            var prevNode = pointer.Prev;

            prevNode.Next = nodeToInsert;
            nodeToInsert.Prev = prevNode;
            nodeToInsert.Next = pointer;
            pointer.Prev = nodeToInsert;
            length++;

        }

        public void DeleteAtIndex(int index)
        {
            if (index == 0 && head != null)
            {
                head = head.Next;
                if (head != null)
                {
                    head.Prev = null;
                }
                length--;
                return;
            }
            else if (index == length - 1 && tail != null)
            {
                tail = tail.Prev;
                if (tail != null)
                {
                    tail.Next = null;
                }
                length--;
                return;
            }
            else if (index >= length)
            {
                return;   
            }
            var pointer = GetNodeAtIndex(index);
            if (pointer != null)
            {
                var prevNode = pointer.Prev;
                var nextNode = pointer.Next;

                pointer.Prev = null;
                pointer.Next = null;
                prevNode.Next = nextNode;
                nextNode.Prev = prevNode;
                length--;
            }

        }

        private Node GetNodeAtIndex(int index)
        {
            Node pointer = head;
            int pointerCounter = 0;
            while (pointerCounter < index)
            {
                pointer = pointer.Next;
                pointerCounter++;
            }
            return pointer;
        }
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */