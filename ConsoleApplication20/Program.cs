using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp17
{
    class Stroka
    {
        public double a;
        public double b;
        //конструктор 
        public Stroka(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        //методы 
        public double plus()
        {
            return a + b;
        }
        public double minus()
        {
            return a - b;
        }
        public double umn()
        {
            return a * b;
        }
        public double del()
        {
            return a / b;
        }
    }
    class Program
    {

        private static double GetBinary()
        {
            String a = Console.ReadLine();
            double b;
            try
            {
                b = double.Parse(a);
                if (a.Replace("1", "").Replace("0", "").Replace(" ", "") != "")
                {
                    Console.WriteLine("не двоичное");
                    return GetBinary();
                }
                else
                {
                    return b;
                }
            }
            catch
            {
                Console.WriteLine("не число");
                return GetBinary();
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введие первое число");
                double a = GetBinary();
                Console.WriteLine("Введие второе число");
                double b = GetBinary();
                Stroka st = new Stroka(a, b);
                //Операция 
                Console.WriteLine("Выберите операцию: ");
                char operac = (char)Console.Read();
                if (operac == '+')
                {
                    Console.WriteLine("Результат: " + st.plus());
                    Console.ReadLine();
                }
                else if (operac == '-')
                {
                    Console.WriteLine("Результат: " + st.minus());
                    Console.ReadLine();
                }
                else if (operac == '*')
                {
                    Console.WriteLine("Результат: " + st.umn());
                    Console.ReadLine();
                }
                else if (operac == '/')
                {
                    Console.WriteLine("Результат: " + st.del());
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Недопустимая операция");
                    Console.ReadLine();
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Попытка деления на ноль");
                Console.ReadLine();
            }

            catch
            {
                Console.WriteLine("Неопознанное исключение");
                Console.ReadLine();
            }
            Console.ReadLine();

        }
    }
}

