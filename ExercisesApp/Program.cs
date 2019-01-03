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
            GetAllFibonacciNumbersInRange(12);
            GetEvenFibonacciNumbersInRange(12);
            GetOddFibonacciNumbersInRange(12);
            Console.ReadLine();
        }

        public static void GetFibonacciNumberInRange(int n)
        {
            int previousNumber = 0;
            int previousPreviousNumber = 0;
            int currentNumber = 1;

            Console.WriteLine("Display number at position " + n + " in Fibonacci sequence...\n");
            for(int i = 1; i < n; i++)
            {
                previousPreviousNumber = previousNumber;
                previousNumber = currentNumber;
                currentNumber = previousNumber + previousPreviousNumber;
            }
                Console.WriteLine(currentNumber + "\n");            
        }

        public static int GetAllFibonacciNumbersInRange(int n)
        {
            int ppn = 0;
            int pn = 0;
            int cn = 1;

            Console.WriteLine("Display all numbers in sequence up to position " + n + " ...\n");
            for(int i= 1; i < n; i++)
            {
                ppn = pn;
                pn = cn;
                cn = ppn + pn;  
            Console.WriteLine(cn);
            }
            return cn;
        }

        public static int GetEvenFibonacciNumbersInRange(int n)
        {
            int ppn = 0;
            int pn = 0;
            int cn = 1;

            Console.WriteLine("Display even numbers in range up to position " + n + " ...\n");
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

        public static int GetOddFibonacciNumbersInRange(int n)
        {
            int ppn = 0;
            int pn = 0;
            int cn = 1;

            Console.WriteLine("Display odd numbers in range up to position " + n + " ...\n");
            for(int i = 1; i < n; i++)
            {
                ppn = pn;
                pn = cn;
                cn = ppn + pn;

                if(cn % 2 == 1)
                {
                    Console.WriteLine(cn);
                }
            }
                return cn;
        }
    }
}
