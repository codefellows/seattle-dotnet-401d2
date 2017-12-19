using System;

namespace Class01Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           // TryCatchStatement();
            DoubleCatch();

        }

        static void TryCatchStatement()
        {
            int milesDriven = 0, gallonsOfGas = 0, mpg = 0;

            try
            {
                Console.WriteLine("Enter Miles Driven");
                string answer = Console.ReadLine();
                milesDriven = Convert.ToInt32(answer);
                // Code that could potentially throw an exceptio

            }
            catch (FormatException e)
            {
                // This block gets hit when an exception is thrown

                Console.WriteLine(e.Message);
                throw;
            }
            catch (Exception x)
            {

            }
        }

        static void DoubleCatch()
        {
            int num = 13, denom = 0, result;

            int[] myArray = { 22, 33, 44 };

            try
            {
                result = myArray[num];
                result = num / denom;
               
            }
            catch (DivideByZeroException error)
            {
                Console.WriteLine("We are in our first catch block");
                Console.WriteLine(error.Message);

            }
            catch (IndexOutOfRangeException error )
            {
                Console.WriteLine("We are in our second catch block");
                Console.WriteLine(error.Message);
                //throw new Exception("This is my custom exception");
            
            }
            finally
            {
                Console.WriteLine("This is my Finally block");
            }

            Console.Read();
        }
    }
}
