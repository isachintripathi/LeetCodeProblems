using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CountODDNumbers
    {
        public int CountOdds(int low, int high)
        {
            int count = 0;
            count = (high - low) / 2;
            if(low%2 != 0 || high%2 != 0)
            {
                count++;
            }
            return count;
        }

        //public int CountOdds(int low, int high)
        //{
        //    int count = 0;
        //    for (int i = low; i <= high; i++)
        //    {
        //        if (i % 2 != 0)
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}
    }
}
