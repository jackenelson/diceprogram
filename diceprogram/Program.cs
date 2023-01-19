using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diceprogram
{
    public class Program
    {  
        public static void Main(string[] args)
        {
            // intro to game and prompt for amount of dice rolls
            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.WriteLine("How many dice rolls would you like to simulate? ");
            int amtRolls = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // generate results from dice roll
            Random r = new Random();
            int[] blah = new int[13];
            for (int i = 0; i < amtRolls; i++)
            {
                int roll1 = r.Next(6)+1;
                int roll2 = r.Next(6)+1;
                int numRoll = roll1 + roll2;
                
                blah[numRoll]++;
            }
            // print results
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \" * \" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + amtRolls);
            Console.Write("\n");

            //histogram
            int[] blahPercent = new int[13];
            for (int i = 2; i < blah.Length; i++)
            {
                Console.Write(i + ": ");
                blahPercent[i] = blah[i]* 100/ amtRolls;
                for (int j = 2; j <= blahPercent[i]; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            // the end
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

        }
    }
}






