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


        static void Main(string[] args)
        {

            //ExploreIf();
        }
    }
}
