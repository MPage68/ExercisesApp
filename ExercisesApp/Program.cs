using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            getFibonacciNumber(12);
            Console.ReadLine();
        }

        public static void getFibonacciNumber(int n)
        {
            int previousNumber = 0;
            int previousPreviousNumber = 0;
            int currentNumber = 1;

            for(int i = 1; i < n; i++)
            {
                previousPreviousNumber = previousNumber;
                previousNumber = currentNumber;
                currentNumber = previousNumber + previousPreviousNumber;
                Console.WriteLine(currentNumber);            
            }
        }
    }
}
