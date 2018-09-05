using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the number for which you want the factorial to be calculated");
            int FacNum = Convert.ToInt32(Console.ReadLine());
            long FactorialUsingIteration= IterativeWay(FacNum);
            long FactorialUsingRecursion= RecurciveWay(FacNum);

            Console.WriteLine("The factorial of " + FacNum + " using Iteration method is {0} \n \n ", FactorialUsingIteration);
            Console.WriteLine("The factorial of " + FacNum + " using Recursion method is {0} \n \n ", FactorialUsingRecursion);
            Console.ReadLine();
        }

        public static long IterativeWay(int myFactorial)
        {
          

            int factorial = myFactorial;

            for (int i = factorial - 1; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
           
        }

        public static long RecurciveWay(int myFactorial)
        {
            if (myFactorial == 0)
            {
                return 1;
            }
            else
            {

                return myFactorial * RecurciveWay(myFactorial - 1);    
            }
        }    
    
            
           
    }
}
