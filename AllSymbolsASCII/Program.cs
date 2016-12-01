using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AllSymbolASCII
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 128; i++)
            {
                char ascii = Convert.ToChar(i);
                // Символы char являются элементами Unicode
                Console.WriteLine("Символ " + ascii + " в числовом виде равен " + i);
                // ASCII - это подмножество Unicode, состоящее из 128 символов
            }
            Console.Read();
        }
    }
}
