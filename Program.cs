using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Айеро";
            string surname = "Фрэнк";
            Console.WriteLine($"Имя {name}, фамилия {surname}");

            string change = name;
            name = surname;
            surname = change;

            Console.WriteLine($"Имя {name}, фамилия {surname}");
            Console.ReadKey(); 
        }
    }
}
