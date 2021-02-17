using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 3.
            Console.WriteLine("Введите число для определения ЧЕТНОЕ или НЕЧЕТНОЕ");
            int a = Convert.ToInt32(Console.ReadLine());


            int b = a % 2;
            if (b % 2 == 0)
            {
                Console.WriteLine($"{a}-Четное число");
            }
            else { Console.WriteLine($"{a}-Нечетное число"); }
        }
    }
}
