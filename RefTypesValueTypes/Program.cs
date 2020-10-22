using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypesValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Value Types
            //int numberOne = 5;
            //IncreaseByOne(numberOne);

            //Console.WriteLine($"The value is: {numberOne}");
            #endregion
            int[] numbers = {1, 2, 3, 4, 5 };
            IncreaseByOne(numbers);

            Console.WriteLine(numbers[0]);
        }

        #region static void IncreaseByOne(int number)
        //{
        //    number++;
        //}
        #endregion

        static void IncreaseByOne(int[] a)
        {
            a[0] = 100;
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
