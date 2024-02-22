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
            ReverseStringAndCheckPalindrome();   
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

        private static void Armstrong()
        {
            Console.WriteLine("Enter the number to be checked");

            int number = Convert.ToInt32(Console.ReadLine());
            int numberCopy = number;
            int sum = 0;
            int digit = 0;

            while(numberCopy > 0)
            {
                digit = numberCopy % 10;
                sum += digit*digit*digit;
                numberCopy = numberCopy/10;
            }

            if(sum == number)
            {
                Console.WriteLine("It is an armstrong number");
            }
            else
            {
                Console.WriteLine("It is not an armstrong number");
            }

            Console.ReadKey();
        }

        private static void MultiplicationTable()
        {
            Console.WriteLine("Enter the number for which the table is required");

            int number = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", number, i, number*i);
            }

            Console.ReadKey();
        }

        private static void Factorial()
        {
            Console.WriteLine("Enter the number");

            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 1;

            for(int i = number; i>0; i--)
            {
                sum *= i;
            }

            Console.WriteLine("Factorial of {0} is {1}", number, sum);
            Console.ReadKey();
        }

        private static void Prime()
        {
            Console.WriteLine("Enter the number to be checked");

            int number = Convert.ToInt32(Console.ReadLine());
            bool prime = true;
            
            for(int i = 2; i <= number / 2; i++)
            {
                if(number % i == 0)
                {
                    Console.WriteLine("Composite");
                    prime = false;
                    break;
                }
            }
            if(number == 1)
            {
                Console.WriteLine("Not defined");
            }
            else if(prime)
            {
                Console.WriteLine("Prime");
            }

            Console.ReadKey();
        }

        private static void PrimeToN()
        {
            Console.WriteLine("Enter the limit");

            int limit = Convert.ToInt32(Console.ReadLine());

            for(int i = 2; i<=limit; i++)
            {
                bool prime = true;

                for(int j = 2; j <= i/2; j++)
                {
                    if(i%j == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                if(prime)
                {
                    Console.WriteLine(i);
                }

            }

            Console.ReadLine();

        }

        private static void PrimeBetweenRange()
        {
            Console.WriteLine("Enter the lower limit");

            int lower = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the upper limit");

            int upper = Convert.ToInt32(Console.ReadLine());

            for (int i = lower; i <= upper; i++)
            {
                bool prime = true;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }

        private static void StarLeftTrianglePattern()
        {
            Console.WriteLine("Enter the number of levels");
            int levels = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= levels; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static void NumberLeftTrianglePattern()
        {
            Console.WriteLine("Enter the number of levels");
            int levels = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= levels; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static void ContinuousEvenNumbersLeftTrianglePattern()
        {
            Console.WriteLine("Enter the number of levels");
            int levels = Convert.ToInt32(Console.ReadLine());
            int printNumber = 2;
            for (int i = 1; i <= levels; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}\t", printNumber);
                    printNumber += 2;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static void ContinuousAlphabetLeftTrianglePattern()
        {
            Console.WriteLine("Enter the number of levels");
            int levels = Convert.ToInt32(Console.ReadLine());
            int printCharacter = 65;
            for (int i = 1; i <= levels; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", (char)printCharacter);
                    printCharacter++;
                    if(printCharacter > 90)
                    {
                        printCharacter = 65;
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static void ContinuousNumbersUpsideDownLeftTrianglePattern()
        {
            Console.WriteLine("Enter the number of levels");
            int levels = Convert.ToInt32(Console.ReadLine());

            for(int i = levels; i > 0; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static void ContinuousNumbersNormalAndUpsideDownLeftTrianglePattern()
        {
            Console.WriteLine("Enter the number of levels");
            int levels = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i<= levels; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }
            for (int i = levels-1; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static void ContinuousNumbersRightTrianglePattern()
        {
            Console.WriteLine("Enter the number of levels");
            int levels = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i<= levels;i++)
            {
                for(int k = 0; k< levels-i; k++)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j<= i; j++)
                {
                    Console.Write("{0}", j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static void NumberPyramidPattern()
        {
            Console.WriteLine("Enter the number of levels");
            int levels = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= levels; i++)
            {
                for (int k = 0; k < levels - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}", j);
                }
                for( int l = i - 1; l >= 1; l--)
                {
                    Console.Write("{0}", l);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static void ReverseStringAndCheckPalindrome()
        {
            Console.WriteLine("Enter the string");
            string word = Console.ReadLine();
            string reverse = "";

            int index = word.Length - 1;

            while(index >= 0)
            {
                reverse = reverse + word[index];
                index--;
            }

            Console.WriteLine("Reversed word is {0}", reverse);

            if(reverse.Equals(word))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a Palindrome");
            }
            Console.ReadKey();
        }
    }
}
