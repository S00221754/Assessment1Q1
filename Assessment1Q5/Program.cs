/*Troy Shilton
 * 17/10/22
 * Assessment1 Q4
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //declare variables
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double salary = 50000;

            //output
            Console.WriteLine($"{InflationSalary(salary)}€");
            Console.ReadLine();
        }
        /// <summary>
        /// adds the inflation percentage to the salary
        /// </summary>
        /// <param name="salary"></param>
        /// <returns></returns>
        static double InflationSalary(double salary)
        {
            double inflation = 0.1, totalSalary;

            totalSalary = salary + (salary * inflation);

            return totalSalary;
        }

    }
}
