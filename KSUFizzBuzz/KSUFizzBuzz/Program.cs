using System;

// NOTES:
// You may have to increase the size of the command prompt to view the output of the program. Right click the window -> Layout -> Screen Buffer Size and set Height to something greater than 100.

namespace KSUFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; ++i)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    //Console.WriteLine(i + " fizzbuzz");
                    Console.WriteLine("fizzbuzz");
                } else if (i % 3 == 0)
                {
                    //Console.WriteLine(i + " fizz");
                    Console.WriteLine("fizz");
                } else if (i % 5 == 0)
                {
                    //Console.WriteLine(i + " buzz");
                    Console.WriteLine("buzz");
                } else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
