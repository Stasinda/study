using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator__switch_
{
    class Switch
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                ShowErrorMessage();
                return;
            }
            var oper = args[0];
            switch (oper)
            {
                case "+":
                    {
                        if (args.Length != 3)
                        {
                            ShowErrorMessage();
                            return;
                        }
                        int a = Convert.ToInt32(args[1]);
                        int b = Convert.ToInt32(args[2]);
                        Console.WriteLine("Сумма чисел равна: " + (a + b));
                        break;
                    }
                case "-":
                    {
                        if (args.Length != 3)
                        {
                            ShowErrorMessage();
                            return;
                        }
                        int a = Convert.ToInt32(args[1]);
                        int b = Convert.ToInt32(args[2]);
                        Console.WriteLine("Разность чисел равна: " + (a - b));
                        break;
                    }
                case "*":
                    {
                        if (args.Length != 3)
                        {
                            ShowErrorMessage();
                            return;
                        }
                        int a = Convert.ToInt32(args[1]);
                        int b = Convert.ToInt32(args[2]);
                        Console.WriteLine("Произведение чисел равно: " + (a * b));
                        break;
                    }
                case "/":
                    {
                        if (args.Length != 3)
                        {
                            ShowErrorMessage();
                            return;
                        }
                        int a = Convert.ToInt32(args[1]);
                        int b = Convert.ToInt32(args[2]);
                        if (b == 0)
                            Console.WriteLine("Деление на 0 запрещено!");
                        else
                            Console.WriteLine("Отношение чисел равно: " + (a / b));
                        break;
                    }
                case "sqr":
                    {
                        if (args.Length != 2)
                        {
                            ShowErrorMessage();
                            return;
                        }
                        int a = Convert.ToInt32(args[1]);
                        Console.WriteLine("Квадрат числа равен: " + (a * a));
                        break;
                    }
                case "sqrt":
                    {
                        if (args.Length != 2)
                        {
                            ShowErrorMessage();
                            return;
                        }
                        int a = Convert.ToInt32(args[1]);
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

        static void ShowErrorMessage()
        {
            Console.WriteLine("calc.exe (математическое действие) (1-ое число) (2-ое число)");
        }
    }
}
