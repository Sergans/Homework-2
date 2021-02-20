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

        }
    }
}
