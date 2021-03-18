using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ІндивідуальнеЗавдання1
{
    class Program
    {
        delegate double MyDelegate(double x);

        static void Main(string[] args)
        {
            Console.WriteLine("Вводьте рядки послідовно один за одним.");
            Console.WriteLine("Поки вони матимуть вигляд: 0 х або 1 х або 2 х (тобто цифра від нуля до двох, а після неї запис конкретного дійсного числа), програма буде обчислювати одну із трьох функцій:");
            Console.WriteLine("");
            Console.WriteLine("    0 -- sqrt(abs(x));");
            Console.WriteLine("    1 -- x^3 (тобто x * x * x);");
            Console.WriteLine("    2 -- x + 3,5;");
            Console.WriteLine("");
            Console.WriteLine("Якщо вхідний рядок не задовольнятиме цей формат, то програма завершить роботу!");

            MyDelegate[] myDelegate = new MyDelegate[] { Function1, Function2, Function3 };
            int[] numberFunction = new int[] { 0, 1, 2 };

            while (true)
            {
                try
                {
                    int[] numbers = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
                    double result = myDelegate[numbers[0]](numbers[1]);

                    Console.WriteLine(result);
                }
                catch (Exception)
                {
                    Console.WriteLine("Помилка: формат введення не вірний! Спробуйте ще раз.");
                    
                }
            }
        }

        static double Function1(double x)
        {
            return Math.Sqrt(Math.Abs(x));
        }

        static double Function2(double x)
        {
            return Math.Pow(x, 3);
        }

        static double Function3(double x)
        {
            return x + 3.5;
        }
    }
}
