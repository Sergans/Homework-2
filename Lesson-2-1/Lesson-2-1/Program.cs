using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_1
{
    class Program
     {  // Добавлен вариант определения месяца по номеру
        //Программа без использвания массива
        enum Month { Январь = 1, Февраль, Март, Апрель, Май, Июнь, Июль, Август, Сентябрь, Октябрь, Ноябрь, Декабрь };
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер месяца");

            int nomberMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((Month)nomberMonth);
            //Задание 1.
            Console.WriteLine("Программа расчета среднесуточной температуры");
             Console.WriteLine("Введите минимальную суточную температуру");
             double minTemperature =Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Введите максимальную суточную температуру");
             double maxTemperature = Convert.ToDouble(Console.ReadLine());
             double mediumTemperature = ((minTemperature + maxTemperature) / 2);
             Console.WriteLine("Среднесуточная температура = " + mediumTemperature + " гадусов");
        }
    }
}
