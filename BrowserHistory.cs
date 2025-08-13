using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class BrowserHistory
    {
        private class Node
        {
            public string Value { get; set; }
            public Node? Prev { get; set; }
            public Node? Next { get; set; }
            public Node(string value)
            {
                Value = value;
                Prev = null;
                Next = null;
            }
        }
        private Node current;
        private Node head;

        public BrowserHistory(string homepage)
        {
            head = current = new Node(homepage);
        }

        public void Visit(string url)
        {
            var visitedNode = new Node(url);
            current.Next = visitedNode;
            visitedNode.Prev = current;
            current = visitedNode;
        }

        public string Back(int steps)
        {
            while(steps > 0 && current.Prev != null)
            {
                current = current.Prev;
                steps--;
            }
            return current.Value;
        }

        public string Forward(int steps)
        {
            while (steps > 0 && current.Next != null)
            {
                current = current.Next;
                steps--;
            }
            return current.Value;
        }
    }

    /**
     * Your BrowserHistory object will be instantiated and called as such:
     * BrowserHistory obj = new BrowserHistory(homepage);
     * obj.Visit(url);
     * string param_2 = obj.Back(steps);
     * string param_3 = obj.Forward(steps);
     */
}
