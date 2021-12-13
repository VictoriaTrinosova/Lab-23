using System;
using System.Threading.Tasks;
using System.Threading;

namespace Lab_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            Method1Async(a);
            Console.WriteLine("Метод Main закончил работу");
            Console.ReadKey();
        }
        static void Method1(int a)
        {
            int c = 1;
            for (int i = 1; i <= a; i++)
            {
                c *= i;
                Thread.Sleep(100);
            }
            Console.WriteLine("Факториал числа {0} равно {1}", a, c);
        }
        static async void Method1Async(int a)
        {
            Console.WriteLine("Метод Method1Async начал работу");
            await Task.Run(() => Method1(a));
            Console.WriteLine("Метод Method1Async закончил работу");
        }
    }
}
