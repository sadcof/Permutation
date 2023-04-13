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

            string lineChanging = name;
            name = surname;
            surname = lineChanging;

            Console.WriteLine($"Имя {name}, фамилия {surname}");
            Console.ReadKey(); 
        }
    }
}
