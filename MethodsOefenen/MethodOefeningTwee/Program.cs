using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOefeningTwee
{
    class Program
    {
        static void Main()
        {
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            GetMax(firstNumber, secondNumber, thirdNumber);

        }

        static void GetMax(int parameterOne, int parameterTwo, int parameterThree)
        {

            if (parameterOne > parameterTwo && parameterOne > parameterThree)
            {
                Console.WriteLine($"The bigger number is: {parameterOne}");
            }

            if (parameterTwo > parameterOne && parameterTwo > parameterThree)
            {
                Console.WriteLine($"The bigger number is: {parameterTwo}");
            }

            if (parameterThree > parameterTwo && parameterThree > parameterOne)
            {
                Console.WriteLine($"The bigger number is: {parameterThree}");
            }

        }
    }
}
