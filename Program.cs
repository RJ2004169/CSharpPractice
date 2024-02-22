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
            Fibonacci();   
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

        private static void NumberLength()
        {
            Console.Clear();

            Console.WriteLine("Enter the number");

            int number = Convert.ToInt32(Console.ReadLine());
            int digits = 0;

            if(number == 0)
            {
                Console.WriteLine("1 digit");
            }
            else
            {
                while (number > 0)
                {
                    digits++;
                    number /= 10;
                }
                Console.WriteLine("{0} digits", digits);
            }

            Console.ReadKey();
        }

        private static void LargestOfThree() 
        {
            Console.Clear();

            Console.WriteLine("Enter the numbers");

            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            if(firstNumber > secondNumber)
            {
                if(firstNumber > thirdNumber)
                {
                    Console.WriteLine("{0} is largest", firstNumber);
                }
                else
                {
                    Console.WriteLine("{0} is largest", thirdNumber); 
                }
            }
            else
            {
                if(secondNumber > thirdNumber)
                {
                    Console.WriteLine("{0} is largest", secondNumber);
                }
                else
                {
                    Console.WriteLine("{0} is largest", thirdNumber);
                }
            }

            Console.ReadKey();
        }

        private static void NNaturalNumbers()
        {
            Console.Clear();

            Console.WriteLine("Enter the value of n");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 1;
            while(n > 0)
            {
                Console.WriteLine(count++);
                n--;
            }

            Console.ReadKey();
        }

        private static void EvenUptoN()
        {
            Console.Clear();

            Console.WriteLine("Enter the value of n");

            int n = Convert.ToInt32(Console.ReadLine());
            int displayNumber = 2;

            while(displayNumber <= n)
            {
                Console.WriteLine(displayNumber); 
                displayNumber += 2;
            }

            Console.ReadKey();
        }

        private static void OddUptoN()
        {
            Console.Clear();

            Console.WriteLine("Enter the value of n");

            int n = Convert.ToInt32(Console.ReadLine());
            int displayNumber = 1;

            if(n > 0)
            {
                do
                {
                    Console.WriteLine(displayNumber);
                    displayNumber += 2;
                } while (displayNumber <= n);
            }
            Console.ReadKey();
        }

        private static void Fibonacci()
        {
            Console.Clear();

            Console.WriteLine("Enter the value of n in the series");

            int n = Convert.ToInt32(Console.ReadLine());

            int first = 0;
            int second = 1;
            int next = 0;

            Console.WriteLine(first);
            Console.WriteLine(second);

            n -= 2;
            
            while (n > 0)
            {
                next = first + second;
                Console.WriteLine(next);
                first = second;
                second = next;
                n--;
            }

            Console.ReadKey();

        }
    }
}
