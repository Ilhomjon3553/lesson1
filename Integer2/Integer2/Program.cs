using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер файла в байтах");
            long size = Convert.ToInt64(Console.ReadLine());
            long kilobytes = size / 1024;
            Console.WriteLine($"Количество полных килобайтов: {kilobytes}");
            Console.ReadKey();
        }
    }
}
