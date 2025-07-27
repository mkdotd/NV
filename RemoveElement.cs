using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class RemoveElement
    {
        public static int RemoveElements(int[] nums, int val)
        {
            int k = nums.Length;
            for (int i = 0; i < k;)
            {
                if(nums[i] == val)
                {
                    k--;
                    int index = i;
                    for(int j = index; j < k; j++)
                    {
                        nums[j] = nums[j+1];
                    }
                    nums[k] = 0;
                }
                else
                {
                    i++;
                }
            }
            return k;
        }        
    }
}
