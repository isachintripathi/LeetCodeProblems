using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SumOfArray
    {
        public int[] RunningSum(int[] nums)
        {
            int count = 0;
            List<int> results = new List<int>();
            for (int i = 0; i < nums.Length - 1; i++)
            {
                results.Add(nums[i]);
                count++;
            }
            return results.ToArray();
        }
    }
}
