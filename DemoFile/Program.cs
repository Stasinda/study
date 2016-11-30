using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DemoFile
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 55295; i++)
            {
                char a;
                //a = Convert.ToChar(i);
                a = char.ConvertFromUtf32(i)[0];
                Console.WriteLine(i + " = " + a + " ");
            }
            Console.Read();
        }
    }
}
