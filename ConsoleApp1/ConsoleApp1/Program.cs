using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сторону квадрата (a):");
            double a = Convert.ToDouble(Console.ReadLine());
            double S = a * a;
            Console.WriteLine($"Площадь квадрата: {S}");
            Console.ReadKey();
        }
    }
}
