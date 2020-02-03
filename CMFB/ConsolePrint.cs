using System;
using System.Collections.Generic;
using System.Text;

namespace CMFizzBuzz
{
    public class ConsolePrint : IDisplayOutput
    {
        public void print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
