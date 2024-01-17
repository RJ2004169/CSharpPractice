using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Program
    {
        public static void Main()
        {
            PositiveOrNegative();   
        }

        private static void PositiveOrNegative()
        {
            Console.Clear();

            Console.WriteLine("Enter the number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            if(num1 < 0)
                Console.WriteLine("Negative");
            else if (num1 > 0)
                Console.WriteLine("Positive");
            else
                Console.WriteLine("Zero");

            Console.ReadKey();
        }

        private static void EvenOrOdd()
        {
            Console.Clear();

            Console.WriteLine("Enter the number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if(num1 == 0)
                Console.WriteLine("Neither odd nor even");
            else
                if(num1 == 2)
                    Console.WriteLine("Odd number");
                else
                {
                    if(num1%2==0)
                        Console.WriteLine("Even number");
                    else
                        Console.WriteLine("Odd number");
                }

            Console.ReadKey();
        }

        private static void LargestNumber()
        {
            Console.Clear();

            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2)
                Console.WriteLine("Greater is {0}", num1);
            else
                Console.WriteLine("Greater is {0}", num2);

            Console.ReadKey();
        }

        private static void Read2NumbersAndPrintSum()
        {
            // Read 2 numbers and print sum

            Console.WriteLine("Enter the numbers to add:");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;

            Console.WriteLine("Sum is " + sum);

            Console.WriteLine("Value of X is {0} \nValue of Y is {1}\nValue of Sum is {2}", num1, num2, sum);

            Console.ReadKey();
        }

        private static void ReadAndPrintString()
        {
            // Read a string and print it

            Console.Clear();

            Console.WriteLine("Enter a string");
            string enteredString = Console.ReadLine();

            Console.WriteLine("String entered is {0}", enteredString);

            Console.ReadKey();
        }

        private static void ReadAndPrintFullName()
        {
            // Read and print full name

            Console.Clear();

            Console.WriteLine("Enter your first name");

            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name");

            string lastName = Console.ReadLine();

            Console.WriteLine("Full name is {0} {1}", firstName, lastName);

            Console.ReadKey();
        }

        private static void Swap2Numbers()
        {
            // Swap 2 numbers without 3rd variable

            Console.Clear();

            Console.WriteLine("Enter the first number");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            firstNum = firstNum + secondNum;
            secondNum = firstNum - secondNum;
            firstNum = firstNum - secondNum;

            Console.WriteLine("Swapped numbers are {0} {1}", firstNum, secondNum);

            Console.ReadKey();
        }

    }
}
