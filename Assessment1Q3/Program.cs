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
            string results = "WDDLWWDLWW";
            int totalPoints = 0, wins = 0, draws = 0, losses = 0;

            for (int i = 0; i < 10; i++)
            {
                char result = results[i];

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
            Console.WriteLine($"{wins} wins");
            Console.WriteLine($"{draws} draws");
            Console.WriteLine($"{losses} losses");
            Console.WriteLine($"Total points: {totalPoints}");
            Console.ReadLine();
        }
    }
}
