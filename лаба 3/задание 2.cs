using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace лаба_3
{
    internal class Program
    {
        static void Main()
        {
            int n, t, c = 0, res = 0, minres = 10000000;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) 
            {
                t = int.Parse(Console.ReadLine());
                if (t == 0 && t == c)
                {
                    res++;
                    if (res < minres)
                    {
                        minres = res;
                    }
                }
                else 
                {
                    res = 0;
                }
                c = t;
            }
            Console.WriteLine("Минимальная последовательность из нулей: " + (minres + 1));
            Console.ReadKey();
        }
    }
}
//Найти минимальную подпоследовательность из нулей.
