using System;

namespace Exceptions_App
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                Console.WriteLine("Hello World!");
                Console.WriteLine("Enter an integer!");
                try
                {
                    int integer1 = int.Parse(Console.ReadLine());
                    int sum = 0;
                    for (int n = integer1; n > 0; sum += n % 10, n /= 10) ;

                    if (integer1 <= 0)
                    {
                        throw new LessThanZeroException();
                    }
                    else if (integer1 > 15)
                    {
                        throw new GreaterThanFifteenException();
                    }
                    else
                    {
                        Console.WriteLine(sum);
                        Console.WriteLine("Time: " + DateTime.Now);
                    }


                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: You didn't enter an integer.");
                    Console.WriteLine("Time: " + DateTime.Now);
                }
                catch (LessThanZeroException)
                {
                    Console.WriteLine("Error: Your input was less than or equal to zero.");
                    Console.WriteLine("Time: " + DateTime.Now);
                }
                catch (GreaterThanFifteenException)
                {
                    Console.WriteLine("Error: Your input was greater than fifteen."); ;
                    Console.WriteLine("Time: " + DateTime.Now);
                }
            }
        }
    }

    class LessThanZeroException : Exception
    {
        
    }
    class GreaterThanFifteenException : Exception
    {

    }
}
