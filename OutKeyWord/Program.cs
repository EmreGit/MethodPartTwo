using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutKeyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 5;
            IncreaseByOne(out numberOne);

            Console.WriteLine($"The value is: {numberOne}");
        }
        // out needs to have value inside the method
        static void IncreaseByOne(out int number)
        {

            number = 1;
        }
    }
}
