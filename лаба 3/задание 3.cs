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
            int n, t, c = 0, res = 0, maxres = -10000000;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) 
            {
                t = int.Parse(Console.ReadLine());
                if (t % 2 == 0)
                {
                    res += t;
                    if (res > maxres) 
                    {
                        maxres = res;
                    }
                }
                else 
                {
                    res = 0;
                }
                c = t;
            }
            Console.WriteLine("максимальная сумма четных чисел из подпоследовательности: " + (maxres));
            Console.ReadKey();
        }
    }
}
//Найти макс сумму четных чисел из одной подпоследовательности.
