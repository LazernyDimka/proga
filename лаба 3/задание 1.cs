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
                if (i != 0 && c == t)
                {
                    res++;
                }
                if (maxres < res)
                {
                    maxres = res;
                }
                else 
                {
                    res = 1;
                }
                c = t;

            }
            Console.WriteLine("Ответ: " + (maxres + 1));
            Console.ReadKey();
        }
    }
}
//Найти длину максимальной подпоследовательности одинаковых элементов.
