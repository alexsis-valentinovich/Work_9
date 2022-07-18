using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.    Смоделируйте работу простого калькулятора. Программа должна запрашивать 2 числа, а затем – код операции
//(например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное). После этого на консоль выводится ответ.
//Используйте обработку исключений для защиты от ввода некорректных данных.
namespace Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа");
            try
            {
                Console.Write("Первое число А=");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Первое число B=");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите действие");
                Console.WriteLine("1-Сложение, 2-вычитание, 3-произведение, 4-деление");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (c == 1)
                {
                    Console.WriteLine("Сумма = {0}", a + b);
                    Console.WriteLine("Выбранное действие - Сложение");
                }
                if (c == 2)
                {
                    Console.WriteLine("Разность = {0}", a - b);
                    Console.WriteLine("Выбранное действие - Вычитание");
                }
                if (c == 3)
                {
                    Console.WriteLine("Произведение = {0}", a * b);
                    Console.WriteLine("Выбранное действие - Умножение");
                }
                if (c == 4)
                {
                    Console.WriteLine("Частное = {0}", a / b);
                    Console.WriteLine("Выбранное действие - Деление");
                }
                if ((c <= 0) || (c > 4))
                {
                    throw new Exception("Числовое значение действия за рамками диапазона");
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("ВНИМАНИЕ. Деление на ноль");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ВНИМАНИЕ {0}", ex.Message);
            }
            Console.ReadKey();
        }
    }
}
