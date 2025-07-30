using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution
    {
        public static ListNode ReverseList(ListNode head)
        {
            ListNode lastHead = null;
            while (head.next != null) { 
            
                var tempNext = head.next;
                head.next = lastHead;
                lastHead = head;
                head = tempNext;
            }
            head.next = lastHead;
            return head;
        }
    }
}
