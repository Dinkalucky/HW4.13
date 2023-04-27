using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[1000000];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1,100);
            }

            ParallelQuery<int> numbers = from nums in array.AsParallel()
                                         where nums%2!=0
                                         select nums;
            foreach (var n in numbers)
            {
                Console.Write(n + ", ");
            }

            Console.ReadKey();
        }
    }
}
