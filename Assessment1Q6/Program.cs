/*Troy Shilton
 * 17/10/22
 * Assessment1 Q6
 */using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare new workers
            Worker worker1, worker2; 
            worker1 = new Worker();
            worker2 = new Worker();
            

            worker1.Name = "Tom";
            worker1.Type = "Plumber";
            worker1.HourlyRate = 15;

            worker2.Name = "Jo";
            worker2.Type = "Electrician";
            worker2.HourlyRate = 20;

            //calling method(output)
            Display(worker1, worker2);
            Console.ReadLine();
        }
        /// <summary>
        /// display workers to console
        /// </summary>
        /// <param name="workers"></param>
        static void Display(params Worker[] workers)
        {
            Console.WriteLine("{0, -12}{1,-17}{2,-10}", "Name", "Type", "Hourly Rate");
            foreach(Worker worker in workers)
            {
                Console.WriteLine("{0, -12}{1,-20}{2,-5}", worker.Name,worker.Type,worker.HourlyRate);
            }
        }
    }
}
