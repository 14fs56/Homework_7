using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7
{
    class Program
    {
        static void Main()
        {
            string stringNumber = "256";

            int numberFromString = Convert.ToInt32(stringNumber); ;

            int square = numberFromString * numberFromString;

            Console.WriteLine("Квадрат введенного числа равен " + square);
        }
    }
}
