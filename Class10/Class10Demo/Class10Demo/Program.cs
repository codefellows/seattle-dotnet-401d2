using System;

namespace Class10Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Console.WriteLine(NRFactorial(5));

            // Console.WriteLine(RFactorial(5));

            Console.WriteLine("Non-Recursive Call");
            Console.WriteLine(NRFibonacci(7));
            Console.WriteLine();
            Console.WriteLine("Recursive Call");
            Console.WriteLine(RFibonacci(7));
        }

        // Non recursive approach
        public static long NRFactorial(int n)
        {
            // 5! = 5 * 4 * 3 * 2 * 1 = 120

            if (n == 0)
            {
                return 1;
            }

            long value = 1;

            for (int i = n; i > 0; i--)
            {
                value *= i;
            }
            return value;
        }

        public static long RFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            long value = n * RFactorial(n - 1);
            Console.WriteLine($"Value is {value}");
            Console.WriteLine($"N is {n}");
            return value;
        }

        public static long NRFibonacci(int r)
        {
            if(r < 2)
            {
                return r;
            }

            long[] f = new long[r + 1];
            f[0] = 0;
            f[1] = 1;

            for (int n = 2; n <= r; n++)
            {
                //F(n) = F(n-1) + F(n-2)
                f[n] = f[n - 1] + f[n - 2];
                
            }

            return f[r];
        }

        public static long RFibonacci(int n)
        {
            if(n <= 1)
                return n;
            return RFibonacci(n-1) + RFibonacci(n-2);
        }


    }
}
