using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsOefeningDrie
{
    class Program
    {
        static void Main(string[] args)
        {

            int userInput = int.Parse(Console.ReadLine());
            Console.Write(" The digits in the number {0} are : ", userInput);

        }

        static void GetLastDigit(int digit)
        {
            
            if (digit < 5)
            {
                
                return;
                GetLastDigit(digit / 10);
                Console.Write(" {0} ", "vijf");
                Console.WriteLine("{0} vijf", digit);
            }

            

        }
        
    }
}
