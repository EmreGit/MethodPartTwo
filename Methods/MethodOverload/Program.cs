using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(10, 20);







            Add(10, 20, 70);
            Add("10", 20);
            Add("1", "2");
        }

        static void Add(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"The result of firstNumber + secondNumber is {firstNumber + secondNumber} ");
        }

        static void Add(string firstNumber, int secondNumber)
        {
            Console.WriteLine($"The result of firstNumber + secondNumber is {int.Parse(firstNumber) + secondNumber} ");
        }
        static void Add(string firstNumber,string secondNumber)
        {
            Console.WriteLine($"The result of firstNumber + secondNumber is {int.Parse(firstNumber) + int.Parse(secondNumber)} ");
        }

        static void Add(int firstNumber, int secondNumber, int thirdNumber)
        {
            Console.WriteLine($"Result of firstNumber + secondNumber + thirdNumber is {firstNumber + secondNumber + thirdNumber}");
        }
    }
}
