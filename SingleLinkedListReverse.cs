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

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode firstNode;
            if(list1 == null) 
                firstNode = list2;
            else if(list2 == null)
                firstNode = list1;
            else
            {
                firstNode = list1.val <= list2.val ? list1 : list2;
            }

            while ((list1 != null && list2 != null))
            {

                var tempList1 = list1.next;
                var tempList2 = list2.next;

                if (list1.val <= list2.val)
                {

                    list1.next = list2;
                    list1 = tempList1;
                }
                else
                {
                    list2.next = list1;
                    list2 = tempList2;
                }

            };



            return firstNode;
        }
    }
}
