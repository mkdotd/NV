using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class DoublyLinkedList
    {
        public DoublyLinkedList Prev { get; set; }
        public int Value { get; set; }
        public DoublyLinkedList Next { get; set; }
        private DoublyLinkedList head;
        private DoublyLinkedList tail;
        public DoublyLinkedList()
        {

        }

        public int Get(int index)
        {

        }

        public void AddAtHead(int val)
        {

        }

        public void AddAtTail(int val)
        {

        }

        public void AddAtIndex(int index, int val)
        {

        }

        public void DeleteAtIndex(int index)
        {

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