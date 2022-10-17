/*Troy Shilton
 * 17/10/22
 * Assessment1 Q1
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double charge = 100, discount = 0, totalPrice;
            string residency;

            //display discounts
            Console.WriteLine("Sligo = 30%, Ireland = 20%, Europe = 10%, Other = 0%");

            //userinput
            Console.Write("Enter place of residency: ");
            residency = Console.ReadLine().ToLower();

            switch (residency) //check residency
            {

                case "sligo":
                    discount = 0.3;
                    break;
                case "ireland":
                    discount = 0.2;
                    break;
                case "europe":
                    discount = 0.1;
                    break;
                default:
                    break;

            }
            //If statment to prevent multiplying by 0 so totalprice does not equal 0.
            if(discount > 0)
            {
                totalPrice = charge - (charge * discount);
            }
            else
            {
                totalPrice = charge;
            }
             
            //output
            Console.WriteLine($"Your discounted price is: {totalPrice}€ ");
            Console.ReadLine();

            
        }
    }
}
