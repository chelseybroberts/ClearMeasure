# ClearMeasure
Write a program that prints the numbers from 1 to 100. 
But for multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz". 
For numbers which are multiples of both three and five print "FizzBuzz".

This project includes the ability to create as many divisibility checks as the user wants and to define them
base on their own desired parameters.
For example, instead of "Fizz" for  number divisible by 3, they could choose to check is a number is divisible
by 10 and if so print "Zazz".

The user can also define the range of values printed out by defining a max value. So that instead of printing 
the numbers from 1 to 100, they could print from 1 to 30 or even from 1 to int.MaxValue

This project also contains unit tests that test the divisibility checker to verify that if a number is divisible
by one of the input values or by more than one of the input values or even by none of the input values the 
correct output will be dispayed.

The ouput is displayed using dependency injection and thus can be modified to print to the Console or to another
display format if desired.
