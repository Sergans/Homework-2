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

            
            //Задание 1.
            
             Console.WriteLine("Введите минимальную суточную температуру");
             double minTemperature =Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Введите максимальную суточную температуру");
             double maxTemperature = Convert.ToDouble(Console.ReadLine());
             double mediumTemperature = ((minTemperature + maxTemperature) / 2);
            if (nomberMonth == 12 || nomberMonth == 1 || nomberMonth == 2 && mediumTemperature > 0)
            {
                Console.WriteLine($"{(Month)nomberMonth} - Дождливая зима");

            }
            else
            {
                Console.WriteLine((Month)nomberMonth);

            }
            Console.WriteLine("Среднесуточная температура = " + mediumTemperature + " гадусов");
        }
    }
}
