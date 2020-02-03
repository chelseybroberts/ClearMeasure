using System;
using System.Collections.Generic;

namespace CMFizzBuzz
{
    public class FizzBuzz
    {
        // print 1-100
        // if n is /3 print "fizz"
        // if n is /5 print "buzz"

        // TODO:
        // x get int.max to work without OOM
        // x using dep inj inject writer to handle print
        // x add unit tests 
        //    x check the % 3&5 case for correct output (f&b)
        // x modify method so that different mods, as many as they want 

        // Create the list of values according to the customer input
        public void createOutput(Dictionary<int, string> keyValues, int max, IDisplayOutput displayOutput)
        {
            for (int i = 1; i <= max; i++)
            {
                // print list to display
                displayOutput.print(divisibilityCheck(keyValues, i));
            }
        }

        // Check divisibility of each number in range against customer input 
        public string divisibilityCheck(Dictionary<int, string> keyValues, int i)
        {
            string str = "";

            // check each number against each divisibility option
            foreach (int key in keyValues.Keys)
            {
                if (i % key == 0)
                {
                    str += keyValues[key];
                }
            }

            // if not divisible by any set value
            if (str.Length == 0)
            {
                str = i.ToString();
            }

            return str;
        }
    }
}
