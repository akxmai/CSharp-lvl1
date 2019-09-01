using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Person
    {
        public string name;
        public string surName;
        public int age;
        public double weight;
        public double height;

        public Person()
        {
            Console.WriteLine("Введите свое имя:");
            name = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию:");
            surName = Console.ReadLine();
            Console.WriteLine("Введите свой возраст:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите свой вес:");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите свой рост:");
            height = Convert.ToDouble(Console.ReadLine());

        }
        public void Write()
        {
            Console.WriteLine($"Имя: {name}, " + $"Фамилия: {surName}, " + $"Возраст: {age}, " + $"Вес: {weight}, " + $"Рост: {height}", .2f);
        }

    }
}
