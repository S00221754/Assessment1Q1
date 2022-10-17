/*Troy Shilton
 * 17/10/22
 * Assessment1 Q1
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int birthYear;

            Console.Write("Enter birth year: ");
            birthYear = int.Parse(Console.ReadLine());

            if(birthYear < 2004)
            {
                Console.WriteLine("You are over 18 therefore you can vote!");
            }
            else
            {
                Console.WriteLine("You are under 18 therefore you cannot vote!");
            }
            Console.ReadLine();
        }
    }
}
