using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HelloWorld
{
    static void Main()
    {
        int n, c = 0, d = 0;
        n = int.Parse(Console.ReadLine());
        while (n > 0)
        {
            d = n % 10;
            if (d % 2 == 0)
            {
                c += d;
                c = c * 10;
            }
            n /= 10;
        }
        if (c == 0)
        {
            Console.WriteLine("Нет чётных цифр");
        }
        else
        {
            c = c / 10;
            Console.WriteLine(c);
        }

    }
}
//Переворачивание чисел и исключение нечётных//