using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator__switch_
{
    class Switch
    {
        static void Main()
        {
            var oper = Console.ReadLine();
            switch(oper)
            {
                case "+":
                    {
                        int a = ReadLineToInt();
                        int b = ReadLineToInt();
                        Console.WriteLine("Сумма чисел равна: " + (a + b));
                        break;
                    }
                case "-":
                    {
                        int a = ReadLineToInt();
                        int b = ReadLineToInt();
                        Console.WriteLine("Разность чисел равна: " + (a - b));
                        break;
                    }
                case "*":
                    {
                        int a = ReadLineToInt();
                        int b = ReadLineToInt();
                        Console.WriteLine("Произведение чисел равно: " + (a * b));
                        break;
                    }
                case "/":
                    {
                        int a = ReadLineToInt();
                        int b = ReadLineToInt();
                        if (b == 0)
                            Console.WriteLine("Деление на 0 запрещено!");
                        else
                            Console.WriteLine("Отношение чисел равно: " + (a / b));
                        break;
                    }
                case "sqr":
                    {
                        int a = ReadLineToInt();
                        Console.WriteLine("Квадрат числа равен: " + (a * a));
                        break;
                    }
                case "sqrt":
                    {
                        int a = ReadLineToInt();
                        Console.WriteLine("Квадратный корень числа равен: " + Math.Sqrt(a).ToString("0.00"));
                        break;
                    }
                default:
                    Console.WriteLine("Ошибка ввода!" + Environment.NewLine + "Введите:" +
                    Environment.NewLine + "+ - сложение;" + Environment.NewLine + "- - вычитание;"
                    + Environment.NewLine + "* - умножение;" + Environment.NewLine + "/ - деление;"
                    + Environment.NewLine + "sqrt - корень числа;" + Environment.NewLine +
                    "sqr - квадрат числа;");
                    break;
            }
        }
        static int ReadLineToInt()
        {
            var num = Console.ReadLine();
            return Convert.ToInt32(num);
        }
    }
}
