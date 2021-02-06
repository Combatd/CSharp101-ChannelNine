using System;

namespace Channel9Numbers
{
    class Program
    {
        static void WorkingWithIntegers()
        {
           // You remember Integers in school, let's see how Math and Integers behave in C#!
           // Spoiler alert - it's more intuitive than you'd expect! We'll talk about order of operations,
           // how numbers divide cleanly(or don't!) and lots more.


            //int a = 18;
            //int b = 6;
            //// addition - 24
            //int c = a + b;
            //Console.WriteLine(c);

            //// subtraction - 12
            //c = a - b;
            //Console.WriteLine(c);

            //// division - 3
            //c = a / b;
            //Console.WriteLine(c);
        }
        static void OrderPrecedence() {

            /*
             * 
             * The C# language defines the precedence of different mathematics operations with rules consistent 
             * with the rules you learned in mathematics. 
             * Multiplication and division take precedence over addition and subtraction. 
             * Explore that by adding the following code to your Main method, and executing dotnet run
             *
             *
             */

            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d); // 13

            // The output demonstrates that the multiplication is performed before the addition.
            /*
             * You can force a different order of operation by adding parentheses 
             * around the operation or operations you want performed first. 
             * Add the following lines and run again:
             */

            d = (a + b) * c;
            Console.WriteLine(d); // 16

            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d); // 25
        }

        static void Main(string[] args) {
            WorkingWithIntegers();
            OrderPrecedence();

            //int a = 7;
            //int b = 4;
            //int c = 3;
            //int d = (a + b) / c;
            //int e = (a + b) % c;
            //Console.WriteLine($"quotient: {d}");
            //Console.WriteLine($"remainder: {e}");

            //// If a calculation produces a value that exceeds those limits, you have an underflow or overflow condition.
            //// The answer appears to wrap from one limit to the other. 
            //int max = int.MaxValue;
            //int min = int.MinValue;
            //Console.WriteLine($"The range of integers is {min} to {max}");

            //int what = max + 3;
            //Console.WriteLine($"An example of overflow: {what}");

            /*
             * Notice that the answer is very close to the minimum (negative) integer. It's the same as min + 2. The addition operation overflowed the allowed values for integers. The answer is a very large negative number because an overflow "wraps around" from the largest possible integer value to the smallest.

                There are other numeric types with different limits and precision that you would use when the int type doesn't meet your needs. Let's explore those other types next.

                Once again, let's move the code you wrote in this section into a separate method. Name it TestLimits.
             * 
             * 
             */

            /*
             * The range of a double value is much greater than integer values.
             * Try the following code below what you've written so far.
             */

            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e + f) / g;
            Console.WriteLine(h); // 5.25

            // doubles are printed in scientific notation when very large
            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");

            // rounding error - this isn't 1/3
            double third = 1.0 / 3.0;
            Console.WriteLine(third); // 0.333...
        }

    }
}
