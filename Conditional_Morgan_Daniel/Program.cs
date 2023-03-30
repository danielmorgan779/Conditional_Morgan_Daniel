using System;

namespace Conditional_Morgan_Daniel
{
    class Program
    {
        static void Main(string[] args)
        {
            // assigns user input to an integer call myWholeNum
            Console.WriteLine("Enter a whole number!");
            int myWholeNum = Convert.ToInt32(Console.ReadLine());

            // Will check and print whether or not it is a positive or negative number
            if (myWholeNum >= 0)
            {
                Console.WriteLine($"{myWholeNum} is a positive number!");
            }
            else
            {
                Console.WriteLine($"{myWholeNum} is a negative number");
            }

            // Checks if whole number is even or odd
            if (myWholeNum % 2 == 0)
            {
                Console.WriteLine($"{myWholeNum} is an even number");
            }
            else
            {
                Console.WriteLine($"{myWholeNum} is a odd number");
            }

            // Two more integers, 6 and 9
            int num1 = 6;
            int otherNum = 99;
            
            // gets first max
            int firstMax = Math.Max(myWholeNum, num1);
            //Max between firstMax and otherNum
            int max = Math.Max(firstMax, otherNum);

            // Prints
            Console.WriteLine($"The max between {myWholeNum}, {num1}, and {otherNum} is {max}...");

            // Makes user input their grade and assigns it to a char called grade
            Console.WriteLine("Enter your grade (A, B, C, D, F)");
            char grade = Console.ReadKey().KeyChar;

            // Prints texts based on their grade
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("\nSuperior");
                    break;
                case 'B':
                    Console.WriteLine("\nVery Good");
                    break;
                case 'C':
                    Console.WriteLine("\nAverage");
                    break;
                case 'D':
                    Console.WriteLine("\nBelow Average");
                    break;
                case 'F':
                    Console.WriteLine("\nFail");
                    break;
                default:
                    break;
            }

        }
    }
}
