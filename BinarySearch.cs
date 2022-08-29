using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            int index, left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                index = left + ((right - left) / 2);
                if (nums[index] == target)
                {
                    return index;
                }

                if (nums[index] < target)
                {
                    left = index + 1;
                }
                else
                {
                    right = index - 1;
                }
            }
            return -1;
        }
    }
}
