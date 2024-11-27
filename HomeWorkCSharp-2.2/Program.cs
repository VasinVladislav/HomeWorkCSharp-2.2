using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.2. Дана сторона квадрата. Найти его периметр.
            Console.WriteLine("Найдите периметр квадрата");
        input:
            Console.Write("Сторона квадрата равна: ");
            double a = Convert.ToDouble(Console.ReadLine());
            while (!(a >= 0))
            {
                Console.WriteLine("Вы ввели неверное значение");
                goto input;
            }
            double P = 4 * a;
            Console.WriteLine("Периметр квадрата равен " + P);
        }
    }
}
