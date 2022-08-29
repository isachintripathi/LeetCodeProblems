using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CalculateAverageSalary
    {
        public double Average(int[] salary)
        {
            double averageSalary = 0;
            Array.Sort(salary);

            for(int i = 1; i< salary.Length-1; i++)
            {
                averageSalary += salary[i];
            }
            return averageSalary/(salary.Length-2);
        }
    }
}
