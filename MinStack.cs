using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class MinStack
    {
        int size = 5;
        int pointer;
        int[] stack;
        public MinStack()
        {
            stack = new int[size];
            pointer = 0;
        }
        public void Push(int val)
        {
            if (pointer < size)
            {
                stack[pointer++] = val;
            }
            else if (pointer == size) {

                //int[] tmp = new int[size];
                size *= 2;
                int[] newstack = new int[size];
                for (int i = 0; i < pointer; i++)
                {
                    newstack[i] = stack[i];
                }
                stack = newstack;
                pointer++;                
            }
        }

        public void Pop()
        {
            if(pointer >= 0)
            {
                stack[--pointer] = 0;
            }
        }

        public int Top()
        {
            if(pointer >= 0)
            {
                return stack[pointer-1];
            } else
                return 0;
        }

        public int GetMin()
        {
            if (pointer >= 0)
            {
                int min = stack[0];
                for (int i = 1; i < pointer; i++)
                {
                    if(min > stack[i])
                    {
                        min = stack[i];
                    } 
                }
                return min;
            }
            else
                return 0;
        }
    }
}
