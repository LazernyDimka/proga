using System;

class HelloWorld
{
    static void Main()
    {
        int k, l, m, n, rez;
        n = Convert.ToInt32(Console.ReadLine());
        l = 3;
        m = 3;
        k = 5;
        rez = (((2 * m + l) * n) + (((k + l) * 2 + (2 * k + l * n * 2)) / 2 * n)) - l * n;

        Console.WriteLine(rez);
    }
}
/* Задача с грядками
