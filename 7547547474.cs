using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            double a = Convert.ToDouble(Console.ReadLine());
            double a2 = Math.Pow(a, 2);
            Console.WriteLine("Ответ:" + a2);
            Console.ReadKey();
     } } }