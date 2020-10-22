using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sum(2, 4);
            //Sum(5, 8, 2);
            //Sum(9, 1, 25, 6);
            Sum(9, 1, 25, 6, 8, 9, 100, 200, 300, 78, 70, 60, 50);

        }
        #region MyRegion 
        //static void Sum(int numberOne, int numberTwo)
        //{
        //    Console.WriteLine(numberOne + numberTwo);
        //}
        //static void Sum(int numberOne, int numberTwo, int thirdNumber)
        //{
        //    Console.WriteLine(numberOne + numberTwo + thirdNumber);
        //}
        //static void Sum(int numberOne, int numberTwo, int thirdNumber, int fourthNumber)
        //{
        //    Console.WriteLine(numberOne + numberTwo + thirdNumber - fourthNumber);
        //}
        #endregion

        static void Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int item in numbers)
            {
                //sum += item;
                Console.WriteLine(sum += item);
            }
        }
    }
}   
