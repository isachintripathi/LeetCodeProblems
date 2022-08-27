using System;

namespace ThreeDimensionalArray{
    public class Calculate{
        public int MaximumWealth(int[][] accounts) {
            int maxWelath = 0;
            foreach(int[] customer in accounts){
                int currentWealth = 0;
                foreach(int wealth in customer){
                    currentWealth += wealth;
                }
                maxWelath = Math.Max(maxWelath, currentWealth);
            }
            return maxWelath;
        }
    }
}