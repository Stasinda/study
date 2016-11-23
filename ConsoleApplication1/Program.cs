using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var act = Console.ReadLine();
            if (act == "+")
            {
                int a = ReadInt();
                int b = ReadInt();
                Console.WriteLine("Сумма равна " + (a + b));
            }
            else if (act == "*")
            {
                int a = ReadInt();
                int b = ReadInt();
                Console.WriteLine("Произведение равно " + (a * b));
            }
            else if (act == "/")
            {
                int a = ReadInt();
                int b = ReadInt();
                if (b == 0)
                    Console.WriteLine("Деление на 0 запрещено!");
                else
                    Console.WriteLine("Отношение равно " + (a / b));
            }
            else if (act == "-")
            {
                int a = ReadInt();
                int b = ReadInt();
                Console.WriteLine("Разность равна " + (a - b));
            }
            else if (act == "sqrt")
            {
                int a = ReadInt();
                Console.WriteLine("Корень числа равен " + Math.Sqrt(a).ToString("0.000"));
            }
            else if (act == "sqr")
            {
                int a = ReadInt();
                Console.WriteLine("Квадрат числа равен " + (a * a));
            }
            else
            {
                Console.WriteLine("Ошибка!" + Environment.NewLine + "Введите:" +
                    Environment.NewLine + "+ - сложение;" + Environment.NewLine + "- - вычитание;"
                    + Environment.NewLine + "* - умножение;" + Environment.NewLine + "/ - деление;"
                    + Environment.NewLine + "sqrt - корень числа;" + Environment.NewLine + 
                    "sqr - квадрат числа;");
            }
            Console.ReadLine();
        }
        static int ReadInt()
        {
            var line1 = Console.ReadLine();
            return Convert.ToInt32(line1);
        }
    }
}
