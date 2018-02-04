using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_number
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.Write("tiv = ");
                int n = Convert.ToInt32(Console.ReadLine());
                int a1 = 1;
                int a2 = 2;
                int fib = 0;
                Console.Write(a1 + "")
                Console.Write(a2 + "")
                for (int i = 2; i < n; i++)
                {
                    fib = a1 + a2;
                    Console.Write(fib + "");
                    a2 = a1;
                    a1 = fib;
                }
                Console.WriteLine();
            }
        }
    }

