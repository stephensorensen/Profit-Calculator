/* Author: Stephen Sorensen
 * Description:
 * Written as a tool to quickly determine profit percentage on invested capital.
 * 
 */
using System;

namespace Profit_Calculator
{
    class Program
    {
        /* Calculate the profit using the formula:
         * Percentage Increase = (Final Value - Starting Value) / Starting Value *100
         */
        static string CalculateProfits(double value1, double value2) 
        {
            double maths = ((value2 - value1) / value1) * 100;
            
            //Convert to string and return formatted to 3 digits after decimal
            return maths.ToString("F3");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("----------------Profit Calculator-------------");
            char input;
                        
            do
            {

                Console.Write("Enter your starting value: ");
                double startAmt = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter your final value: ");
                double profAmt = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Your Percentage return is: " + CalculateProfits(startAmt, profAmt) + "%");
                Console.WriteLine("Run again? (y/n)");
                input = Convert.ToChar(Console.ReadLine());
                bool result;
                result = input.Equals('n');
                if (result){
                    Console.WriteLine("Goodbye");
                }
                result = input.Equals('y');
                if(result){
                    Console.WriteLine("Running again");
                }
                       
            } while (Char.ToLower(input) != 'n');

        }
    }
}
