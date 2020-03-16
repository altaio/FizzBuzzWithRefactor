using NUnit.Framework;
using FizzBuzzApp;
using System.Text;

namespace Tests
{
    public class Part1Tests
    {
        private static FizzBuzzCheck SetupFBCheckForPart1()
        {
            var FBCheck = new FizzBuzzCheck();
            FBCheck.AddRule(3, "fizz");
            FBCheck.AddRule(5, "buzz");
            return FBCheck;
        }

        [Test]
        public void Part1FizzTest([Values(3, 6, 9, 12, 18)] int input)
        {
            FizzBuzzCheck FBCheck = SetupFBCheckForPart1();
            string resultString;

            resultString = FizzBuzzProgram.FizzBuzzCheckNumber(input, FBCheck);
            Assert.AreEqual("fizz", resultString);
        }

        [Test]
        public void Part1BuzzTest([Values(5, 10, 20)] int input)
        {
            FizzBuzzCheck FBCheck = SetupFBCheckForPart1();
            string resultString;

            resultString = FizzBuzzProgram.FizzBuzzCheckNumber(input, FBCheck);
            Assert.AreEqual("buzz", resultString);
        }

        [Test]
        public void Part1FizzBuzzTest([Values(15)] int input)
        {
            FizzBuzzCheck FBCheck = SetupFBCheckForPart1();
            string resultString;

            resultString = FizzBuzzProgram.FizzBuzzCheckNumber(input, FBCheck);
            Assert.AreEqual("fizzbuzz", resultString);
        }

        [Test]
        public void Part1NegativeTests([Values(1, 2, 4, 7, 8, 23, 52)] int input)
        {
            FizzBuzzCheck FBCheck = SetupFBCheckForPart1();
            string resultString;

            resultString = FizzBuzzProgram.FizzBuzzCheckNumber(input, FBCheck);
            Assert.AreEqual(input.ToString(), resultString);
        }

    }

    public class Part2Tests
    {
        private static FizzBuzzCheck SetupFBCheckForPart2()
        {
            var FBCheck = new FizzBuzzCheck();
            FBCheck.AddRule(3, "fizz");
            FBCheck.AddRule(5, "buzz");
            FBCheck.AddRule("3", "fizz");
            FBCheck.AddRule("5", "buzz");
            return FBCheck;
        }

        [Test]
        public void Part2FizzTest([Values(23)] int input)
        {
            FizzBuzzCheck FBCheck = SetupFBCheckForPart2();
            string resultString;

            resultString = FizzBuzzProgram.FizzBuzzCheckNumber(input, FBCheck);
            Assert.AreEqual("fizz", resultString);
        }

        [Test]
        public void Part2BuzzTest([Values(52, 55, 56)] int input)
        {
            FizzBuzzCheck FBCheck = SetupFBCheckForPart2();
            string resultString;

            resultString = FizzBuzzProgram.FizzBuzzCheckNumber(input, FBCheck);
            Assert.AreEqual("buzz", resultString);
        }

        [Test]
        public void Part2NegativeTest([Values(46)] int input)
        {
            FizzBuzzCheck FBCheck = SetupFBCheckForPart2();
            string resultString;

            resultString = FizzBuzzProgram.FizzBuzzCheckNumber(input, FBCheck);
            Assert.AreEqual(input.ToString(), resultString);
        }

    }

}

