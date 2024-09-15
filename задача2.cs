using System;

class HelloWorld
{
    static void Main()
    {
        int a, b, c, d;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Math.Abs(a - b);
        d = (a + b - c) / 2;

        Console.WriteLine(d);
    }
}
/* выведение меньшего числа