using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int integerEntered;
            bool run = true;

            Console.WriteLine("Learn your squares and cubes!");
            Console.WriteLine();
            Console.WriteLine();

            while (run == true)
            {
                //Prompt the user for an integer
                Console.Write("Please enter an integer: ");
                integerEntered = int.Parse(Console.ReadLine());

                Console.WriteLine();

                //Print table header
                Console.WriteLine(string.Format("{0,-10} {1,-10} {2}", "Number", "Squared", "Cubed"));
                Console.WriteLine("================================");

                //Display the original number, the square of that number, & the cube of that number beginning with 1 and ending with the integer specified by the user
                for (int i = 1; i <= integerEntered; i++)
                {
                    Console.WriteLine(string.Format("{0,-10} {1,-10} {2}", i, GetSquare(i), GetCube(i)));
                }

                //Prompt the user to continue
                Console.WriteLine();
                run = Continue();
                Console.WriteLine();
            }
        }

        static int GetSquare(int intToSquare)
        {
            int intSquared;
            intSquared = intToSquare * intToSquare;
            return intSquared;
        }

        static int GetCube(int intToCube)
        {
            int intCubed;
            intCubed = intToCube * intToCube * intToCube;
            return intCubed;
        }

        static bool Continue()
        {
            Console.Write("Would you like to continue (Y/N)? ");
            string input = Console.ReadLine().ToUpper();
            bool doAgain;
            if (input == "Y")
            {
                doAgain = true;
            }
            else if (input == "N")
            {
                doAgain = false;
            }
            else
            {
                Console.WriteLine("That is not a valid response. Please try again.");
                doAgain = Continue();
            }

            return doAgain;
        }
    }

    
}
