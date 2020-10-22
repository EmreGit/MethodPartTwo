using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefKeyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 5;
            IncreaseByOne(numberOne);

            Console.WriteLine($"The value is: {numberOne}");
        }
        static void IncreaseByOne(int number)
        {
            number++;
        }
    }
}
