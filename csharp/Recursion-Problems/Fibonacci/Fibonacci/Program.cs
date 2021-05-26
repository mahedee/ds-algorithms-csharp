using System;

/* Fibonacci - Pronunciation - Fi-buh-naa-chee(ফিবোনাছি)
 * Input: n = 5
 * Output: Fibonacci series of 5 numbers is: 0 1 1 2 3
 * 
 * Mathematical equation: 
 * n if n == 0 or n == 1;
 * fib(n) = fib(n-1) + fib(n-2) otherwise;
 * 
 */
namespace Fibonacci
{
    class Program
    {
        public static int Fib(int n)
        {
            // Stop or base condition
            // 0 th fibonacci number is 0
            if (n == 0)
                return 0;

            // Stop codition
            if (n == 1 || n == 2)
                return 1;
            
            // Recursion function
            else
                return (Fib(n - 1) + Fib(n - 2));
        }

        public static int Fib2(int n)
        {
            // use this variable to understand properly by debugging
            int fib1, fib2, fibSum;

            // stop condition
            if (n == 0 || n == 1)
                return n;
            else
            {
                fib1 = Fib2(n - 1);
                fib2 = Fib2(n - 2);
                fibSum = fib1 + fib2;
                return fibSum;
            }
        }

        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine("Fibonacci series of 5 numbers is: ");

            // for loop to print the fibonacci series.
            for(int i = 0; i < n; i ++)
            {
                //Console.Write(Fib(i) + " ");

                // Can use the following to understand better by debugging
                Console.Write(Fib2(i) + " ");
            }


            //int fib = Fib2(n);
            //Console.WriteLine(fib);
        }
    }
}
