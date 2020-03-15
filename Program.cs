using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KentRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Written by:  Dennis Sklack
            //  This is the base code to handle the funtion required.  It could be used in WFP, WVVM, Client/Server, or Web.  
            //  Here is the base logic

            // For the numbers
            for (int iLoop = 1; iLoop <= 100; iLoop++)
            {
                string sOut = "";

                //See if includes a 3
                if (iLoop.ToString().Contains("3"))
                {
                    sOut = "fizz";
                }

                //See if contains 5
                else if (iLoop.ToString().Contains("5"))
                {
                    sOut = "buzz";
                }

                //Use other setup
                else
                {
                    //See if divisible by 3
                    if ((iLoop / 3) * 3 == iLoop)
                    {
                        sOut = "fizz";
                    }

                    //See if divisible by 5
                    if ((iLoop / 5) * 5 == iLoop)
                    {
                        sOut += "buzz";
                    }
                }

                //If neither display number
                if (sOut == "") sOut = iLoop.ToString();

                //Print result
                Console.WriteLine(sOut);
            }

            //All done,  This is a Console App, so print message and wait for keystroke
            Console.WriteLine("Enter any key to complete.");
            Console.ReadKey();

        }
    }
}
