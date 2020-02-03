using System;
using Xunit;
using CMFizzBuzz;
using System.Collections.Generic;

namespace XUnitClearMFBTesting
{
    public class CMFizzBuzzTest
    {
        private FizzBuzz _fizzBuzz;

        private Dictionary<int, string> dict = new Dictionary<int, string>()
            {
                {3, "Fizz"},
                {5, "Buzz"}
            };

        public CMFizzBuzzTest()
        {
            _fizzBuzz = new FizzBuzz();
        }
        
        [Fact]
        public void checkForFizz()
        {
            Assert.Equal("Fizz", _fizzBuzz.divisibilityCheck(dict, 3));
        }

        [Fact]
        public void checkForBuzz()
        {
            Assert.Equal("Buzz", _fizzBuzz.divisibilityCheck(dict, 5));
        }

        [Fact]
        public void checkForFizzBuzz()
        {
            Assert.Equal("FizzBuzz", _fizzBuzz.divisibilityCheck(dict, 15));
        }

        [Fact]
        public void checkForNumber()
        {
            Assert.Equal("1", _fizzBuzz.divisibilityCheck(dict, 1));
        }
    }
}
