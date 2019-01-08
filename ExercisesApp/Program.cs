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
            GetFibonacciNumberInRange(24);
            GetAllFibonacciNumbersInRange(12);
            GetEvenFibonacciNumbersInRange(12);
            GetOddFibonacciNumbersInRange(12);
            GetSumOfAllFibonacciNumbersInRange(12);
            GetSumOfAllEvenFibonacciNumbersInRange(12);
            GetSumOfOddFibonacciNumbersInRange(12);
            GetStartAndEndPointInFibonacciRange(12,24);
            GetNumbersBetweenStartAndEndPointOfFibonacci(12,24);
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
                Console.WriteLine(currentNumber + "\n");            
        }

        public static int GetAllFibonacciNumbersInRange(int n)
        {
            int ppn = 0;
            int pn = 0;
            int cn = 1;

            Console.WriteLine("Display all numbers in sequence up to position " + n + " ...");
            for(int i= 1; i < n; i++)
            {
                ppn = pn;
                pn = cn;
                cn = ppn + pn;  
            Console.WriteLine(cn);
            }
            Console.WriteLine();
            return cn;
        }

        public static int GetEvenFibonacciNumbersInRange(int n)
        {
            int ppn = 0;
            int pn = 0;
            int cn = 1;

            Console.WriteLine("Display even numbers in range up to position " + n + " ...");
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
            Console.WriteLine();
            return cn;
        }

        public static int GetOddFibonacciNumbersInRange(int n)
        {
            int ppn = 0;
            int pn = 0;
            int cn = 1;

            Console.WriteLine("Display odd numbers in range up to position " + n + " ...");
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
            Console.WriteLine();
            return cn;
        }

        public static int GetSumOfAllFibonacciNumbersInRange(int n)
        {
            int ppn = 0;
            int pn = 0;
            int cn = 1;
            int sum = 0;

            Console.WriteLine("Display the sum of numbers in range up to position " + n + " ...");
            for(int i = 1; i < n; i++)
            {
                ppn = pn;
                pn = cn;
                cn = ppn + pn;
                sum += cn;
            }
            Console.WriteLine(sum + "\n");
            return sum;
        }   
        
        public static int GetSumOfAllEvenFibonacciNumbersInRange(int n)
        {
            int ppn = 0;
            int pn = 0;
            int cn = 1;
            int sum = 0;

            Console.WriteLine("Display sum of all even numbers in Fibonacci sequence up to " + n);
            for(int i = 1; i < n; i++)
            {
                ppn = pn;
                pn = cn;
                cn = ppn + pn;

                if (cn % 2 == 0)
                    sum += cn;
            }
            Console.WriteLine(sum + "\n");
            return sum;
        }

        public static int GetSumOfOddFibonacciNumbersInRange(int n)
        {
            int ppn = 0;
            int pn = 0;
            int cn = 1;
            int sum = 0;

            Console.WriteLine("Display sum of odd Fibonacci number in range up to " + n);
            for(int i = 1; i < n; i++)
            {
                ppn = pn;
                pn = cn;
                cn = ppn + pn;

                if (cn % 2 == 1)
                    sum += cn;
            }
            Console.WriteLine(sum + "\n");
            return sum;
        }

        public static int GetStartAndEndPointInFibonacciRange(int start, int end)
        {
            int ppn = 0;
            int pn = 0;
            int cn = 1;

            Console.WriteLine("Display the numbers at the " + start + " and " + end + " positions in the Fibonacci sequence");

            for(int i = 1; i < end; i++)
            {
                ppn = pn;
                pn = cn;
                cn = ppn + pn;

                if(i == start - 1)
                {
                    Console.WriteLine("Position 12 of the sequence is " +cn);
                }                  
             
            }
            Console.WriteLine("Position 24 of the sequence is " + cn + "\n");
                return cn;
        }

        public static int GetNumbersBetweenStartAndEndPointOfFibonacci(int start, int end)
        {
            int ppn = 0;
            int pn = 0;
            int cn = 1;

            Console.WriteLine("Display the numbers between " + start + " and " + end + " in the Fibonacci sequence");
            for(int i = 1; i < end; i++)
            {
                ppn = pn;
                pn = cn;
                cn = ppn + pn;

                if(i >= start)
                {
                    Console.WriteLine(cn);
                }
            }
            Console.WriteLine();
            return cn;
        }
    }

}
