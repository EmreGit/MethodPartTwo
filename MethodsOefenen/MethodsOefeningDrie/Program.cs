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

            //GreetTheUser();
            NumberToGreet();


        }

        //static void GetLastDigit(int digit)
        //{

        //    if (digit < 5)
        //    {
        //        Console.WriteLine("{0} vijf", digit);
        //        return;
        //    }

        //    GetLastDigit(digit / 10);
        //    Console.Write(" {0} ", digit % 10);

        //    num = Math.Abs(num);
        //    string ans = Convert.ToString(num);
        //    int i = ans.Length;
        //    return ans[i = nth];

        //}

        //static void GreetTheUser()
        //{
        //    Console.WriteLine("Please type in a number: ");
        //    int userInput = int.Parse(Console.ReadLine());

        //    for (int i = userInput; i <= 20; i++)
        //    {
        //        Console.WriteLine("##############");
        //        Console.WriteLine(i);
        //    }
        //}

        static void NumberToGreet()
        {
            Console.WriteLine("Please write your name: ");
            string userName = Console.ReadLine();

            if (true)
            {
                Console.WriteLine("Hello {0} ", userName);
            }

        }

    }
}
  


      
