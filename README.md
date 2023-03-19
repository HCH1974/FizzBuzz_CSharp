# FizzBuzz C Sharp

A simple C Sharp program to play fizzbuzz.

## Setup

To execute this program, run the command dotnet run. You will need to enter the number to count up to and the rules you want implemented, 3 5 7 11 13

“Fizz“ whenever the number is a multiple of 3

“Buzz” whenever the number is a multiple of 5

If a number is a multiple of 7, print "Bang" instead of the number. For numbers which are multiples of seven and three / five, append Bang to what you'd have printed anyway. (E.g. 3 * 7 = 21: "FizzBang").

If a number is a multiple of 11, print "Bong" instead of the number. Do not print anything else in these cases. (E.g. 3 * 11 = 33: "Bong")

If a number is a multiple of 13, print "Fezz" instead of the number. For multiples of most other numbers, the Fezz goes immediately in front of the first thing beginning with B, or at the end if there are none. (E.g. 5 * 13 = 65: "FezzBuzz", 3 * 5 * 13 = 195: "FizzFezzBuzz"). Note that Fezz should be printed even if Bong is also present (E.g. 11 * 13 = 143: "FezzBong")

