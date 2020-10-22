using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Add(10, 5);

            if (result == 15)
            {
                Console.WriteLine("Operation is ok");
            }
            else
            {
                Console.WriteLine("There was a problem in your input");
            }
        }

        //              10      5
        static int Add(int a, int b)
        {
            int x = a + b; // 10 + 5 = 15
            Console.WriteLine(x);
            return x;
        }

    }
}
