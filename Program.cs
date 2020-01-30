using System;

namespace Recursions_optionalparams
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            if (a <= 60)
            {
                Console.WriteLine("Grade is a F");
            }

            else if (a <= 70)
            {
                Console.WriteLine("Grade is a D");
            }

            else if (a <= 80)
            {
                Console.WriteLine("Grade is a C");
            }

            else if (a <= 90)
            {
                Console.WriteLine("Grade is a B");
            }

            else if (a <= 100)
            {
                Console.WriteLine("Grade is a A");
            }
            return a;

            
        }

        static void Main()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }
    }



}



