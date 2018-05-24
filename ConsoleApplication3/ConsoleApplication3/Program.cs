using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Stroka
    {
        int a;
        int b;
        //конструктор 
        public Stroka(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        //методы 
        public string plus()
        {
            return Convert.ToString(a + b, 2);
        }
        public string minus()
        {
            return Convert.ToString(a - b, 2);
        }
        public string umn()
        {
            return Convert.ToString(a * b, 2);
        }
        public string del()
        {
            return Convert.ToString(a / b, 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());

            string s1 = Convert.ToString(a, 2);
            Console.WriteLine("В двоичной системе счисления это: " + s1);
            Console.WriteLine("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());
            string s2 = Convert.ToString(b, 2);
            Console.WriteLine("В двоичной системе счисления это: " + s2);
            Stroka st = new Stroka(a, b);

            Console.WriteLine("Выберите операцию:");
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
            Console.ReadLine();
        }

    }
}
