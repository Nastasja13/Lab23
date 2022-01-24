using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab23
{
    class Program
    {
        // Разработать асинхронный метод для вычисления факториала числа. В методе Main выполнить проверку работы метода.
        static void Main(string[] args)
        {
            Console.Write($"Введите число, чтобы вычеслить его факториал: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Factorial(n);
            Console.ReadKey();
        }
        static void Factorial(int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
                Thread.Sleep(100);
            }

            Console.WriteLine($"Факториал числа {n}! равен {f}");
        }
        static async void FactorialAsync(int n)
        {
           await Task.Run(() => Factorial(n));
        }
    }
}