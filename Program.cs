using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая работа № 5"; // заголовок консоли

            int a, b, c; // объявление переменных

            Console.WriteLine("Здравствуйте!");
            Console.Write("Введите a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите с = ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a == b || b == c || c == a)
                Console.Write("Числа не должны быть равны");

            // проверка условия

            if (a > b && a > c && b > c)
                Console.WriteLine($"Результат: {c},{b},{a} ");
            if (a > b && a > c && c > b)
                Console.WriteLine($"Результат: {b},{c},{a} ");
            if (a > b && a < c && c > b)
                Console.WriteLine($"Результат: {b},{a},{c} ");
            if (a < b && b > c && a > c)
                Console.WriteLine($"Результат: {c},{a},{b} ");
            if (a < b && b > c && a < c)
                Console.WriteLine($"Результат: {a},{c},{b} ");
            if (a < b && b < c && c > a)
                Console.WriteLine($"Результат: {a},{b},{c} ");

            Console.ReadKey();
        }
    }
}
