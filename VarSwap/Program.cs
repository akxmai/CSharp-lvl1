using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 переменные - A и B:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            a += b;
            b = a - b;
            a -= b;

            Console.WriteLine($"A = {a}, B = {b}");
            Console.ReadLine();
        }
    }
}
