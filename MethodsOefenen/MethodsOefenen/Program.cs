using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsOefenen
{
    class Program
    {
        static void Main()
        {
            AddName(Console.ReadLine());
            
        }

        static void AddName(string userName)
        {
            Console.WriteLine($"Hallo, {userName}");
        }
    }
}
