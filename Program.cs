using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            #region Day 1: Binary Search
            //int[] nums = { -1, 0, 3, 5, 9, 12 };
            //int target = -1;
            //BinarySearch binarySearch = new BinarySearch();
            //int index = binarySearch.Search(nums, target);
            //Console.WriteLine("Index is " + index);
            //Console.ReadKey(true);
            #endregion

            #region Day 1: SearchInsertPosition
            //int[] nums = { 1, 3, 5, 6 };
            //int target = 7;
            //SearchInsertPosition binarySearch = new SearchInsertPosition();
            //int index = binarySearch.SearchInsert(nums, target);
            //Console.WriteLine("Target index is " + index);
            //Console.ReadKey(true);
            #endregion

            #region Day 1: CountODDNumbers
            //int count = 0, low = 1, high = 10;
            //CountODDNumbers number = new CountODDNumbers();
            //count = number.CountOdds(low, high);
            //Console.WriteLine("Total ODD count is " + count);
            //Console.ReadKey(true);
            #endregion

            #region Day 1: CalculateAverageSalary Except Lowest & Highest Salary
            //int[] salaries = {4000, 3000, 1000, 2000};
            //double avg = 0;
            //CalculateAverageSalary salary = new CalculateAverageSalary();
            //avg = salary.Average(salaries);
            //Console.WriteLine("Average Salary is " + avg);
            //Console.ReadKey(true);
            #endregion

            #region Day 1: CountODDNumbers
            //int[] nums = {3,1,2,10,1}, results;
            //SumOfArray sum = new SumOfArray();
            //results = sum.RunningSum(nums);
            //Console.WriteLine("Sum is " + results);
            //Console.ReadKey(true);
            #endregion

            #region Day 2: CountODDNumbers
            //int[] nums = { -4, -1, 0, 3, 10 }, results;
            //SortedArraySquares sas = new SortedArraySquares();
            //results = sas.SortedSquares(nums);
            //Console.WriteLine(results);
            //Console.ReadKey(true);
            #endregion

            #region Day 2: RotateArray
            int[] nums = { 1,2,3,4,5,6,7 };
            RotateArray array = new RotateArray();
            array.Rotate(nums, 3);
            Console.WriteLine(array);
            Console.ReadKey(true);
            #endregion
        }
    }
}
