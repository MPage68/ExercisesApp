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
            GetFibonacciNumberInRange(12);
            GetEvenFibonacciNumber(12);
            Console.ReadLine();
        }

        public static void GetFibonacciNumberInRange(int n)
        {
            int previousNumber = 0;
            int previousPreviousNumber = 0;
            int currentNumber = 1;

            Console.WriteLine("Display number at position " + n + " in Fibonacci sequence...");
            for(int i = 1; i < n; i++)
            {
                previousPreviousNumber = previousNumber;
                previousNumber = currentNumber;
                currentNumber = previousNumber + previousPreviousNumber;
            }
                Console.WriteLine(currentNumber);            
        }

        public static int GetEvenFibonacciNumber(int n)
        {
            int ppn = 0;
            int pn = 0;
            int cn = 1;

            Console.WriteLine("Display even numbers in range...");
            for(int i = 1; i < n; i++)
            {
                ppn = pn;
                pn = cn;
                cn = ppn + pn;

                if(cn % 2 == 0)
                {
                Console.WriteLine(cn);
                }
            }
                return cn;
        }
    }
}
