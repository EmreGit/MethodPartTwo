using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(Multiplication(2, 4));
            //Console.WriteLine(Multiplication(2, 4, 5));
            Multiplication(2, 3, ConsoleColor.Green);

        }
        #region
        //static int Multiplication(int numberOne, int numberTwo, int numberThree=1) //Parameters with reauired value AFTER non-valued parameters
        //{
        //    //int result;
        //    return numberOne* numberTwo * numberThree;

        //}
        #endregion
        static void Multiplication(int numberOne, int numberTwo, ConsoleColor color = ConsoleColor.DarkMagenta) //Parameters with required value AFTER non-valued parameters
        {
            //int result;
            Console.ForegroundColor = color;
            Console.WriteLine(numberOne * numberTwo);
            //Console.ResetColor();

        }



    }
}

