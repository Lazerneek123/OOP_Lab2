using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_4
{
    class Program
    {
        delegate void MyDelegate(double number);

        static void Main(string[] args)
        {
            MyDelegate[] myDelegate = new MyDelegate[] { Row1, Row2, Row3 };

            for (int i = 0; i < myDelegate.Length; i++)
            {                
                myDelegate[0](i + 1);
                myDelegate[1](i + 1);
                myDelegate[2](i + 2);
            }

            /*MyDelegate myDelegate1 = Row1;
            Console.WriteLine("Ряд №1 =>");

            for (int i = 1; i <= 5; i++)
            {
                myDelegate1(i);
            }
           
            MyDelegate myDelegate2 = Row2;
            Console.WriteLine();
            Console.WriteLine("Ряд №2 =>");

            for (int i = 2; i <= 6; i++)
            {
                myDelegate2(i);
            }

            MyDelegate myDelegate3 = Row3;
            Console.WriteLine();
            Console.WriteLine("Ряд №3 =>");

            for (int i = 1; i <= 5; i++)
            {
                myDelegate3(i);
            }*/

            Console.ReadKey();
        }

        static void Row1(double number)
        {
            double sum = 0;
            Console.WriteLine();

            for (int i = 0; i <= number; i++)
            {
                double n = 1 / Math.Pow(2, i);

                if (i == 0)
                {
                    Console.Write("{0}) {1}", number, n);
                }
                else
                {
                    Console.Write(" + " + n);
                }
                
                sum += n;
            }

            Console.WriteLine(" = " + Math.Round(sum, 2));
        }

        static void Row2(double number)
        {
            double sum = 0;
            Console.WriteLine();

            for (int i = 1; i <= number; i++)
            {
                double n = 1 / Factorial(i);

                if (i == 1)
                {                    
                                       
                    Console.Write("{0}) {1}", number - 1, i);
                }
                else
                {
                    Console.Write(" + " + n);
                }

                sum += n;
            }

            Console.WriteLine(" = " + Math.Round(sum, 2));
        }

        static void Row3(double number)
        {
            double sum = 0;
            Console.WriteLine();

            for (int i = 0; i <= number; i++)
            {
                double n = 1 / Math.Pow(2, i);

                if (i == 0)
                {
                    sum += n;
                    Console.Write("{0}) {1}", number, n);
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        sum -= n;
                        Console.Write(" - " + n);
                    }
                    else
                    {
                        sum += n;
                        Console.Write(" + " + n);
                    }

                    
                }
               
            }

            Console.WriteLine(" = " + Math.Round(sum, 2));
        }

        static double Factorial(int i)
        {
            if (i == 0)
            {
                return 1;
            }
            else
            {
                return i * Factorial(i - 1);
            }
        }
    }
}
