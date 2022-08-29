using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SortedArraySquares
    {
        public int[] SortedSquares(int[] nums)
        {
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                nums[i] = nums[i] * nums[i];
            }
            Array.Sort(nums);
            return nums;
        }
    }
}
