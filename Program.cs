using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            //There's a staircase with N steps, and you can climb 1 or 2 steps at a time. Given N, write a function that returns the number of unique ways you can climb the staircase. The order of the steps matters.

            //For example, if N is 4, then there are 5 unique ways:
            // - 1, 1, 1, 1
            // - 2, 1, 1
            // - 1, 2, 1
            // - 1, 1, 2
            // - 2, 2
            
           // 1> [1]
           // 2> [1,1],[2]
           // 3> [1,1,1], [1,2], [2,1]
           // 4> [1,1,1,1], [1,2,1], [1,1,2], [2,1,1], [2, 2]
           // 5> [1,1,1,1,1], [2,1,1,1], [1,2,1,1], [1,1,2,1], [1,1,1,2], [2,2,1], [2,1,2], [1,2,2]
           // 6> [1,1,1,1,1,1], [2,1,1,1,1], [1,2,1,1,1], [1,1,2,1,1], [1,1,1,2,1], [1,1,1,1,2], [2,2,2], [2,2,1,1], [1,2,2,1], [1,2,1,2], [2,1,2,1], [1,1,2,2]
           // 7> [1,1,1,1,1,1,1], [2,1,1,1,1,1], [1,2,1,1,1,1], [1,1,2,1,1,1], [1,1,1,2,1,1], [1,1,1,1,2,1], [1,1,1,1,1,2], [2,2,1,1,1], [2,1,2,1,1], [2,1,1,2,1], [2,1,1,1,2], [1,2,1,1,2], [1,1,2,1,2], [1,1,1,2,2], [2,2,2,1], [2,2,1,2], [2,1,2,2], [1,2,2,2]
           // 8> 

            //What if, instead of being able to climb 1 or 2 steps at a time, you could climb any number from a set of positive integers X? For example, if X = { 1, 3, 5}, you could climb 1, 3, or 5 steps at a time. Generalize your function to take in X.

            Console.WriteLine("Hello World!");
            Console.WriteLine("How Many steps are there?");
            var steps = Convert.ToInt32(Console.ReadLine());
            var res = UniqueWays(steps);
            Console.WriteLine("There are " + res + " steps");
            Console.ReadKey();

            
        }
        public static int UniqueWays(int steps)
        {
            if(steps <= 1)
            {
                return 1;
            }
            return UniqueWays(steps - 1) + UniqueWays(steps - 2);
        }
    }
}
