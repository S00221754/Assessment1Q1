/*Troy Shilton
 * 17/10/22
 * Assessment1 Q4
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment1Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //filepath
            string filePath = @"C:\Users\s00221754\OneDrive - Atlantic TU\Semester 3\OOP\Assessment1Q1\Assessment1Q4\movieRatings.txt";

            //arrays 
            string[] fields = new string[10]; //fields is user to store the ratings
            string[] scores =  File.ReadAllLines(filePath);

            //declare variables
            string tableFormat = "{0,-25} {1,-15}";
            double rating, avgRating;
            string movieName;

            Console.WriteLine(tableFormat, "Movie name", "Avg Rating");
            
            foreach(string score in scores)
            {
                fields = score.Split(',');
                movieName = fields[0]; //movie name is at the start of each line.
                double totalRating = 0;
                for (int i = 1; i <= 10; i++) //used to read in ratings from 1-10.
                {
                    rating = int.Parse(fields[i]);
                    totalRating = totalRating + rating;
                }

                avgRating = totalRating / 10;

                //output
                Console.WriteLine(tableFormat, fields[0], avgRating);
            }
            Console.ReadLine();

        }
    }
}
