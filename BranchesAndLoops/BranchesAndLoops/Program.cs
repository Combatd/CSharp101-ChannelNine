using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void ExploreIf()
        {
            //int a = 5;
            //int b = 6;
            //b = 3;
            //if (a + b > 10)
            //    Console.WriteLine("The answer is greater than 10.");
            //else
            //    Console.WriteLine("The answer is not greater than 10");

            /*
             * The indentation under the if and else statements is for human readers. 
             * The C# language doesn't treat indentation or white space as significant. 
             * The statement following the if or else keyword will be executed based on the condition. 
             * 
             * Because indentation isn't significant, you need to use { and } to indicate 
             * when you want more than one statement to be part of the block that 
             * executes conditionally. 
             * C# programmers typically use those braces on all if and else clauses. 
             * The following example is the same as the one you created. 
             * Modify your code above to match the following code:
             */

            int a = 5;
            int b = 3;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }

            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }

            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }
        }

        static int sumOfTwentyIntegersDivisibleBy3()
        {
            int sum = 0;

            for (int i = 1; i < 20; i++)
            {
                if (i % 3 == 0) // if the iterator  value is divisible by 3
                {
                    sum += i;
                }
            }

            return sum;
        }


        static void Main(string[] args)
        {

            //ExploreIf();

            //int counter = 0;
            //while (counter < 10)
            //{
            //    Console.WriteLine($"Hello World! The counter is {counter}");
            //    counter++;
            //}

            /*
             * Make sure that the while loop condition changes to false as you execute the code. 
             * Otherwise, you create an infinite loop where your program never ends.
             */

            // The while loop tests the condition before executing the code following the while.
            // The do while loop executes the code first, and then checks the condition.

            int counter = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);

            // initializer; condition; iterator
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }

            // O(n^2)
            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }

            Console.WriteLine(sumOfTwentyIntegersDivisibleBy3());
        }
    }
}
