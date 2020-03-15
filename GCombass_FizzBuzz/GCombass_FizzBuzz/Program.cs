using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCombass_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> fizzBuzzStepOne = FizzBuzzWithMod(); //Part 1 output stored as a list of strings
            List<string> fizzBuzzStepTwo = FizzBuzzWithContains(fizzBuzzStepOne); //Part 2 output based on part 1 list of strings

            foreach (var x in fizzBuzzStepTwo)
            {
                Console.WriteLine(x);
            }

            //Console.ReadLine(); //Testing Line for Visual Studio Debugging
        }

        static List<string> FizzBuzzWithMod()
        {
            List<string> modList = new List<string>();

            for (int i = 1; i <= 100; i++)
            {
                var output = (i % 15 == 0) ? "FizzBuzz" : (i % 5 == 0) ? "Buzz" : (i % 3 == 0) ? "Fizz" : i.ToString();

               modList.Add(output);
            }
            return modList;
        }

        static List<string> FizzBuzzWithContains(List<string> fizzBuzzStepOne)
        {
            List<string> containsList = new List<string>();

            foreach (var x in fizzBuzzStepOne)
            {
                var output = ((x.Contains("3")) && (x.Contains("5"))) ? "FizzBuzz" : (x.Contains("3")) ? "Fizz" : (x.Contains("5")) ? "Buzz" : x;

                containsList.Add(output);
            }
            return containsList;  
        }
    }
}
