using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой рост и вес:");
            double height = Convert.ToDouble(Console.ReadLine());
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Ваш индекс массы тела равен {weight/(height*height)}");
            Console.ReadLine();
        }
    }
}
