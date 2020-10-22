using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLogo
{
    class Program
    {
        static void Main()
        {
            #region repeat something

            //Console.WriteLine("My name is Emre");
            //Console.WriteLine("I am learning C");
            //Console.WriteLine("I think it's a lot of fun");
            //Console.WriteLine(star);

            //Console.WriteLine("My name is Emre");
            //Console.WriteLine("I am learning C");
            //Console.WriteLine("I think it's a lot of fun");
            //Console.WriteLine(star);

            //Console.WriteLine("My name is Emre");
            //Console.WriteLine("I am learning C");
            //Console.WriteLine("I think it's a lot of fun");
            //Console.WriteLine(star);

            //Console.WriteLine("My name is Emre");
            //Console.WriteLine("I am learning C");
            //Console.WriteLine("I think it's a lot of fun");
            //Console.WriteLine(star);
            #endregion

            //for (int i = 0; i < 10; i++)
            //{
            //    PrintLogo();
            //}

            //PrintLogo();

            // Calculate(5, 10);
            //ShowString(10, 20,"Emre");
            Show(6, 7);
        }

        #region Printlogo
        //static void PrintLogo()
        //{
        //    string star = new string('*', 50);

        //    Console.WriteLine("My name is Emre");
        //    Console.WriteLine("I am learning C");
        //    Console.WriteLine("I think it's a lot of fun");
        //    Console.WriteLine(star);
        //}
        #endregion

        //static void Calculate(int a, int b)
        //{
        //    int result = a + b;
        //    Console.WriteLine("The result is : "+ result); 
        //}

        //static void ShowString(int a, int b, string c)
        //{
        //    int result = a + b;
        //    Console.WriteLine($"The result is : {a+b} {c}");
        //}

        static void Show(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("A is bigger");
            }
            else if (b > a)
            {
                Console.WriteLine("B is bigger");

            }
            else
            {
                Console.WriteLine("A and B are the same");
            }
        }
    }
}
