/* Name:         FizzBuzzApp Console Program
 * Description:  
                 Part 1:
                 For numbers 1 through 100:
                 For every number divisible by 3 print "fizz".
                 For every number divisible by 5 print "buzz".
                 For every number divisible by both 3 and 5 print "fizzbuzz".
                 Otherwise print the number.
                 Part 2:
                 For every number that includes a 3 in it, print "fizz"
                 For every number that includes a 5 in it, print "buzz"
                 The previous fizzbuzz functionality must still work.
 * Author:       Disney Maxwell 
 * Date Created: 3/14/2020
 * Notes:
 * Problem Statement link: https://github.com/altaio/FizzBuzzWithRefactor
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzApp
{
    public class FizzBuzzProgram
    {
        static void Main(string[] args)
        {
            int i;
            string resultString;

            Console.WriteLine("Begin fizzbuzz Program.");
            Console.ReadKey();

            var FizzBuzzCheck = new FizzBuzzCheck();
            FizzBuzzCheck.AddRule(3, "fizz");
            FizzBuzzCheck.AddRule(5, "buzz");
            FizzBuzzCheck.AddRule("3", "fizz");
            FizzBuzzCheck.AddRule("5", "buzz");

            for (i = 1; i <= 100; i++)
            {
                resultString = FizzBuzzCheckNumber(i, FizzBuzzCheck);
                Console.WriteLine(resultString);
            }

            Console.WriteLine("End Program!");
            Console.ReadKey();
        }

        public static string FizzBuzzCheckNumber(int number, FizzBuzzCheck FizzBuzzCheck)
        {
            var tempResultBuilder = new StringBuilder();

            foreach (var x in FizzBuzzCheck.rules)
            {
                if (x.Divisor != 0)
                    tempResultBuilder.Append(number % x.Divisor == 0 ? x.Output : "");

                if (tempResultBuilder.ToString().Length == 0)
                {
                    tempResultBuilder.Append(number.ToString().Contains(x.StringCheck) ? x.Output : "");
                }
            }
            string tempResultString = tempResultBuilder.ToString();
            tempResultBuilder.Clear();

            string finalResultString = (String.IsNullOrWhiteSpace(tempResultString) ? number.ToString() : tempResultString);
            return finalResultString;
        }
    }

    public class FizzBuzzCheck
    {
        internal class Rule
        {
            internal int Divisor;
            internal string StringCheck = "noStringCheck";
            internal string Output;
        }

        internal List<Rule> rules;

        public FizzBuzzCheck()
        {
            rules = new List<Rule>();
        }

        public void AddRule(int divisor, string output)
        {
            rules.Add(new Rule() { Divisor = divisor, Output = output });
        }

        public void AddRule(string stringCheck, string output)
        {
            rules.Add(new Rule() { StringCheck = stringCheck, Output = output });
        }

        internal string Check(int number, int divisor, string output)
        {
            return (number % divisor == 0 ? output : "");
        }

        internal string Check(int number, string stringCheck, string output)
        {
            return (number.ToString().Contains(stringCheck) ? output : "");
        }

    }

    //public static string FizzBuzzCheck(int j)
    //{

    //    string fbResult = "";

    //    if ((j % 15) == 0)
    //    {
    //        fbResult = "fizzbuzz";
    //    }
    //    else if ((j % 3) == 0)
    //    {
    //        fbResult = "fizz";
    //    }
    //    else if ((j % 5) == 0)
    //    {
    //        fbResult = "buzz";
    //    }
    //    else
    //    {
    //        fbResult = j.ToString();
    //    }

    //    return fbResult;

    //    //else if (j.ToString().Contains("3"))
    //    //{
    //    //    fbResult = "fizz";
    //    //}
    //    //else if (j.ToString().Contains("5"))
    //    //{
    //    //    fbResult = "buzz";
    //    //}

    //}

}

