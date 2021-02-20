using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_6
{
    class Program
    {
        [Flags]
        enum Days

        {
            Понедельник = 0b0000001,
            Вторник = 0b0000010,
            Среда = 0b0000100,
            Четверг = 0b0001000,
            Пятница = 0b0010000,
            Суббота = 0b0100000,
            Воскресенье = 0b1000000
        }
        static void Main(string[] args)
        {
            //Присвоение значений графиков работы
            Days allDays = (Days)0b1111111;
            Days workOffice1 = (Days)0b0011110;//График работы офиса1
            Days workOffice2 = (Days)0b1111111;// График работы офиса2
            Days weekEndOf1 = workOffice1 ^ allDays;//Выходные дни офис1
            Days weekEndOf2 = workOffice2 ^ allDays;//Выходные дни офис2
            //Вывод графиков с проверкой на выходные
            Console.WriteLine($"График работы офиса1:{workOffice1}");
            if (weekEndOf1 == 0)
            {
                Console.WriteLine("Выходные дни-Без выходных");
            }
            else
            {
                Console.WriteLine($"Выходные дни:{weekEndOf1}");
            }
            Console.WriteLine($"График работы офиса2:{workOffice2}");
            if (weekEndOf2 == 0)
            {
                Console.WriteLine("Выходные дни-Без выходных");
            }
            else
            {
                Console.WriteLine($"Выходные дни:{weekEndOf2}");
            }
        }
    }
}
