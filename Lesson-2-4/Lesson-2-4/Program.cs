using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //ЧЕК
            DateTime data = DateTime.Now;
            string organizayion = "ООО ВАШ ЦЕЛИТЕЛЬ";
            string adress = "г.Калуга, Калужская обл. ул Вишнeвского д.2";
            long nomber = 84842725993;
            int term = 10859147;
            decimal purchase;
            Console.WriteLine("Введите сумму покупки,чтобы пробить чек");
            // Без проверки входных данных
            purchase = Convert.ToDecimal(Console.ReadLine());
            
            Console.WriteLine($"{organizayion}\n{adress}\nт. {nomber}\n{data}\nТерминал:{term}\nСумма покупки(руб): {purchase}\nОДОБРЕНО");
        }
    }
}
