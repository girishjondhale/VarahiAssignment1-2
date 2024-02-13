using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarahiAssignment
{
    internal class CuriousNumber
    {
        
        static int Factorial(int n)
        {
                int result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result = result * i;
                }
                return result;
            
        }
        static int FactorialOfDigits(int number)
        {
            int result = 0;

            while (number > 0)
            {
                int Digit = number % 10;

                int digitFactorial = Factorial(Digit);

                result = result + digitFactorial;

                number = number / 10;
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = FactorialOfDigits(number);

            Console.WriteLine($"The sum of factorial of digits is {result}");
        }
    }
}
