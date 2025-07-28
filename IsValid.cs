using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class IsValid
    {
        public bool IsValidS(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s) {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' && (stack.Count == 0 || stack.Pop() != '(')) { return false; }
                else if (c == ']' && (stack.Count == 0 || stack.Pop() != '[')) { return false; }
                else if (c == '}' && (stack.Count == 0 || stack.Pop() != '{')) { return false; }
            }
            return stack.Count == 0;
        }        
    }
}
