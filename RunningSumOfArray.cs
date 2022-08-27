using System;

namespace Array
{
    public class RunningSumOfArray
    {
        public int[] Sum(int[] array)
        {
            int[] results = new int[array.Length];
            results[0] = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                results[i] = array[i] + results[i-1];
            }
            return results;
        }
    }
}