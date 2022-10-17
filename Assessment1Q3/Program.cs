/*Troy Shilton
 * 17/10/22
 * Assessment1 Q1
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string results = "WDDLWWDLWW";
            int totalPoints = 0, wins = 0, draws = 0, losses = 0; //counters

            for (int i = 0; i < 10; i++)
            {
                char result = results[i]; //checks each individual character in string results.

                if(result == 'W')
                {
                    totalPoints = totalPoints + 3;
                    wins++;
                }
                else if(result == 'D')
                {
                    totalPoints++;
                    draws++;
                }
                else if (result == 'L')
                {
                    losses++;
                }
            }

            //output
            Console.WriteLine($"{wins} wins");
            Console.WriteLine($"{draws} draws");
            Console.WriteLine($"{losses} losses");
            Console.WriteLine($"Total points: {totalPoints}");
            Console.ReadLine();
        }
    }
}
