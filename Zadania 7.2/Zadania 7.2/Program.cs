using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zadania_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            String text = Console.ReadLine();

            Console.WriteLine("Введите слово");
            String word = Console.ReadLine();

            int count = 0;

            string[] mas = text.Split(' ');
            foreach (string s in mas)
            {
                if (s == word) count++;
            }

            Console.WriteLine("Слово: {0} \nвстречается в тексте: {1} раз", word, count);

        }
    }
}
