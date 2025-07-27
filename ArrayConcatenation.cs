using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ArrayConcatenation
    {
        public static int[] ArrayConcatenations(int[] nums)
        {
            int k = nums.Length;
            int[] ans = new int[ k * 2];
            for (int i = 0; i < k; i++)
            {
                ans[i] = nums[i];
                ans[i+k] = nums[i];
            
            }

            return ans;
        }        
    }
}
