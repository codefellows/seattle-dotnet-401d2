using System;

namespace DemoDay2
{
    public class FizzBuzz
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string Convert(int n)
        {
            if (n % 15 == 0)
            {
                return "FizzBuzz";
            }
            if (n % 3 == 0)
            {
                return "Fizz";
            }
            if (n % 5 == 0)
            {
                return "Buzz";
            }

            return n.ToString();
        }
    }
}
