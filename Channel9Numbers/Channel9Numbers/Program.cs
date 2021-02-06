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
        }

    }
}
