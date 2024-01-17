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

            //// Read 2 numbers and print sum

            //Console.WriteLine("Enter the numbers to add:");

            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            
            //int sum = num1 + num2;

            //Console.WriteLine("Sum is " + sum);

            //Console.WriteLine("Value of X is {0} \nValue of Y is {1}\nValue of Sum is {2}", num1, num2, sum);

            //Console.ReadKey();
            
            //// Read a string and print it

            //Console.Clear();

            //Console.WriteLine("Enter a string");
            //string enteredString = Console.ReadLine();

            //Console.WriteLine("String entered is {0}", enteredString);

            //Console.ReadKey();

            // Read and print full name

            Console.Clear();

            Console.WriteLine("Enter your first name");

            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name");

            string lastName = Console.ReadLine();

            Console.WriteLine("Full name is {0} {1}", firstName, lastName);

            Console.ReadKey();
        }
    }
}
