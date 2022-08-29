using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            if (nums == null || nums.Length < 2)
                return;
            int n = nums.Length;
            k %= nums.Length;
            Array.Reverse(nums, 0, n);
            Array.Reverse(nums, 0, k);
            Array.Reverse(nums, k, n-k);
        }
    }
}
