using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task13._2
{
    internal class Program
    {
        static void MyMethod1()
        {
            Console.WriteLine("MyMethod1 запущено");
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(50);
                Console.WriteLine("*");
            }
            Console.WriteLine("MyMethod1 завершено");
        }
        static void MyMethod2()
        {
            Console.WriteLine("MyMethod2 запущено");
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(50);
                Console.WriteLine("+");
            }
            Console.WriteLine("MyMethod2 завершено");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Метод Main запущено");

            ParallelOptions parallelOptions = new ParallelOptions();
            parallelOptions.MaxDegreeOfParallelism = 2;

            Parallel.Invoke(parallelOptions,MyMethod1,MyMethod2);
            Console.WriteLine("Метод Main завершено");
            Console.ReadLine();
        }
    }
}
