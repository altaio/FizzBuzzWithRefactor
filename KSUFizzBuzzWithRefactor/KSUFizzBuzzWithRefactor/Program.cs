using System;

namespace KSUFizzBuzz
{
    class Program
    {
        // These methods return the ones and tens place of any number provided
        static int OnesPlace(int num)
        {
            return num % 10;
        }

        static int TensPlace(int num)
        {
            return num % 100 / 10;
        }

        static void Main(string[] args)
        {
            for (int i = 1; i < 101; ++i)
            {
                //Console.WriteLine(i.ToString() + ' ' + HundredsPlace(i).ToString() + TensPlace(i).ToString() + OnesPlace(i).ToString());

                int t1 = OnesPlace(i);
                int t2 = TensPlace(i);

                if (t1 == 3 && t2 == 5 || t1 == 5 && t2 == 3) // Print "fizzbuzz' for 35 and 53
                {
                    //Console.WriteLine(i + " fizzbuzz");
                    Console.WriteLine("fizzbuzz");
                } else if (t1 == 3 || t2 == 3)
                {
                    //Console.WriteLine(i + " fizz");
                    Console.WriteLine("fizz");
                } else if (t1 == 5 || t2 == 5)
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
