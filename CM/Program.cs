using System;
using System.Collections.Generic;
using CMFizzBuzz;

namespace CM
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz FizzBuzz = new FizzBuzz();

            // Customer input of as many divisibility checks as they want
            // Can be gathered from the console and added to the input dictionary
            //      or from another source

            Dictionary<int, string> input = new Dictionary<int, string>()
            {
                {3, "Fizz"},
                {5, "Buzz"}
                //{10, "Zazz"}
            };

            // Range that can be set by the customer
            int max = 30;

            FizzBuzz.createOutput(input, max, new ConsolePrint());
        }

    }
}
