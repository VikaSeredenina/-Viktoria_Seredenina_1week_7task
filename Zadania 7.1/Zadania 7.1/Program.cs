using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string a = Console.ReadLine();
            Console.WriteLine("Исходная строка: " + a);
            Console.Write("Введите символ x: ");
            string x = Console.ReadLine();

            string res = a.Replace(x, string.Empty);
            Console.WriteLine("Измененная строка: " + res);
         
        }
    }
}
