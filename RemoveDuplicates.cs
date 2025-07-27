using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class RemoveDuplicates
    {
        public static int RemoveDuplicate(int[] nums)
        {
            int k = nums.Length;
            for (int i = 1; i < k;)
            {
                if(nums[i-1] == nums[i])
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
