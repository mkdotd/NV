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
            while (head.next != null)
            {

                var tempNext = head.next;
                head.next = lastHead;
                lastHead = head;
                head = tempNext;
            }
            head.next = lastHead;
            return head;
        }

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode firstNode = new ListNode();
            ListNode pointer = firstNode;
            while (list1 != null || list2 != null)
            {
                if (list1 == null)
                {
                    pointer.next = list2;
                    break;
                }
                else if (list2 == null)
                {
                    pointer.next = list1;
                    break;
                }
                else
                {

                    if (list1.val <= list2.val)
                    {
                        pointer.next = list1;
                        list1 = list1.next;
                    }
                    else
                    {
                        pointer.next = list2;
                        list2 = list2.next;
                    }
                    pointer = pointer.next;
                }

            }
            return firstNode.next;
        }
    }
}
