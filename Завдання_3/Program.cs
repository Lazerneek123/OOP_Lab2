using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_3
{
    class Program
    {
        delegate void MyDelecate(int number1, int number2);

        static void Main(string[] args)
        {
            int[] array = CreateArray();
            MyDelecate myDelecate = Audit;

            Console.Write("Масив =>");
            Console.WriteLine();

            foreach (int i in array)
            {
                Console.Write("{0}, ", i);
            }

            Console.WriteLine();

            Console.WriteLine("Введіть число на яке ви будете ділити:");
            int k = Int32.Parse(Console.ReadLine());

            foreach (int i in array)
            {
                myDelecate(i, k);
            }

            Console.ReadKey();

        }        

        static int[] CreateArray()
        {
            Random random = new Random();
            int[] array = new int[100];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
            }


            return array;
        }

        static void Audit(int number1, int number2)
        {
            if (number1 % number2 == 0)
            {
                Console.WriteLine("Число: " + number1 + " - є кратним числам {0}!", number2);
            }
        }
    }
}
